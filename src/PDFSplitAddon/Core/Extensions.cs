using System.Reflection;
using System.Linq;
using SwissAcademic.Pdf;
using System;
using System.IO;
using SwissAcademic.Citavi.Metadata;
using System.Collections.Generic;
using SwissAcademic.Citavi;

namespace PDFSplit
{
    public static class Extensions
    {
        #region System.string

        public static string AddPräfix(this string value, string präfix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(präfix)) return value;

            return präfix + value;
        }

        public static string AddSuffix(this string value, string suffix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(suffix)) return value;

            return value + suffix;
        }

        public static string Trim(this string result, FileNameTrimType fileNameTrimType, int maxLength)
        {
            if (result.Length > maxLength)
            {
                int diff = result.Length - maxLength;

                switch (fileNameTrimType)
                {
                    case FileNameTrimType.FromStart:
                        return result.Substring(diff);
                    case FileNameTrimType.FromEnd:
                        return result.Substring(0, result.Length - diff);
                }
            }

            return result;
        }

        #endregion

        #region System.Reflection.Generic.T

        public static B GetProperty<T, B>(this T obj, BindingFlags flags, string name) where T : class where B : class
        {
            var type = obj.GetType();
            var propertyInfos = type.GetProperties(flags);
            var propertyInfo = propertyInfos.FirstOrDefault(prop => prop.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (propertyInfo == null) return null;

            return propertyInfo.GetValue(obj) as B;

        }

        #endregion

        #region SwissAcademic.Pdf.Document

        public static string GetPageLabelTextOrDefault(this Document document, int pageNumber, string defaultValue)
        {
            var pageLabel = document.GetPageLabel(pageNumber);

            if (!pageLabel.IsValid()) return defaultValue;

            var pageLabelText = pageLabel.GetLabelTitle(pageNumber);

            if (string.IsNullOrEmpty(pageLabelText)) return defaultValue;

            return pageLabelText;
        }

        #endregion

        #region SwissAcademic.Citavi.Reference

        public static string ProposeLocalFilePath(this Reference reference, string fileNameOrExtension, bool renameWithOptions = true)
        {
            if (reference == null) throw new ArgumentNullException("reference");

            string fileName;

            if (renameWithOptions)
            {
                fileName = reference.ProposeFileName();
                var isOldUsed = false;
                if (string.IsNullOrEmpty(fileName))
                {
                    if (string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(fileNameOrExtension)))
                    {
                        fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
                    }
                    else
                    {
                        fileName = fileNameOrExtension;
                        isOldUsed = true;
                    }
                }

                string extension = Path.GetExtension(fileNameOrExtension);
                if (!string.IsNullOrEmpty(extension) && !isOldUsed) fileName = fileName + extension;
            }
            else
            {
                fileName = Path.GetFileName(fileNameOrExtension);
                var extension = Path.GetExtension(fileNameOrExtension);

                if (string.IsNullOrEmpty(fileName) || extension == fileNameOrExtension)
                    fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());

                if (!fileName.EndsWith(Path.GetExtension(fileNameOrExtension))) fileName += Path.GetExtension(fileNameOrExtension);
            }

            return new DirectoryInfo(reference.Project.Engine.DesktopEngineConfiguration.GetFolderPath(CitaviFolder.Attachments, reference.Project)).GetUniqueFilePath(fileName);
        }

        public static string ProposeFileName(this Reference source, FileNameTrimType fileNameTrimType = FileNameTrimType.None)
        {
            if (source == null)
                return null;

            var renameSettings = source.Project.Engine.Settings.Engine.Settings.Rename;

            // TODO DL: für 5.2 abändern http://tfs2012:8080/tfs/CITAVICollection/Citavi/_workitems/edit/17175
            //var values = renameSettings.NameDefineIds .Select(id => GetValue(source, id)).ToList();
            var values = new List<ReferencePropertyId> { ReferencePropertyId.ShortTitle }.Select(id => source.GetReferencePropertybyId(id)).ToList();
            values.RemoveAll(v => string.IsNullOrWhiteSpace(v));

            var result = string.Join(renameSettings.Separator.ToStringSeparator(), values);

            if (string.IsNullOrEmpty(result)) return null;

            result = Path2.GetValidFileName(result.Clean());

            if (fileNameTrimType != FileNameTrimType.None) result = result.Trim(fileNameTrimType, renameSettings.MaxNameLength);

            return result;
        }

        static string GetReferencePropertybyId(this Reference reference, ReferencePropertyId propertyId)
        {
            switch (propertyId)
            {
                case ReferencePropertyId.Title:
                    {
                        if (!string.IsNullOrEmpty(reference.Title)) return reference.Title;
                    }
                    break;

                case ReferencePropertyId.Periodical:
                    {
                        if (reference.Periodical != null) return reference.Periodical.StandardAbbreviationAuto;
                    }
                    break;

                case ReferencePropertyId.Subtitle:
                    {
                        if (!string.IsNullOrEmpty(reference.Subtitle)) return reference.Subtitle;
                    }
                    break;

                case ReferencePropertyId.YearResolved:
                    {
                        if (!string.IsNullOrEmpty(reference.YearResolved)) return reference.YearResolved;
                    }
                    break;

                case ReferencePropertyId.ShortTitle:
                    {
                        if (!string.IsNullOrEmpty(reference.ShortTitle)) return reference.ShortTitle;
                    }
                    break;

                case ReferencePropertyId.AuthorsOrEditorsOrOrganizations:
                    {
                        if (reference.AuthorsOrEditorsOrOrganizations.Any()) return reference.AuthorsOrEditorsOrOrganizations.First().LastName;
                    }
                    break;

                case ReferencePropertyId.CustomField1:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField1)) return reference.CustomField1;
                    }
                    break;

                case ReferencePropertyId.CustomField2:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField2)) return reference.CustomField2;
                    }
                    break;

                case ReferencePropertyId.CustomField3:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField3)) return reference.CustomField3;
                    }
                    break;

                case ReferencePropertyId.CustomField4:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField4)) return reference.CustomField4;
                    }
                    break;

                case ReferencePropertyId.CustomField5:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField5)) return reference.CustomField5;
                    }
                    break;

                case ReferencePropertyId.CustomField6:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField6)) return reference.CustomField6;
                    }
                    break;

                case ReferencePropertyId.CustomField7:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField7)) return reference.CustomField7;
                    }
                    break;

                case ReferencePropertyId.CustomField8:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField8)) return reference.CustomField8;
                    }
                    break;

                case ReferencePropertyId.CustomField9:
                    {
                        if (!string.IsNullOrEmpty(reference.CustomField9)) return reference.CustomField9;
                    }
                    break;
            }

            return string.Empty;
        }

        #endregion
    }
}
