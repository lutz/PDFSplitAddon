# PDFSplitAddon

This add-on adds a new function to the context menu of local PDF files. This function allows you to cut parent PDFs for their child titles.

## Releases

The compiled library can be found under [releases](./../../releases) as an archive.

## Usage

Note: This add-on can only be used with local (!) projects, not with cloud projects. It is also important, that this add-on can only be used with contributions in parent references. This add-on extracts the required pages from the entire PDF of the book and assigns them as an attachment to each contribution.

Please follow these steps:

1. Install the update to the current version of Citavi 6 [Download](https://www.citavi.com/download). You can also [check here](https://www.citavi.com/beta) to see if a beta version is available that contains all the latest bug fixes.
2. Close Citavi 6.
3. On the [add-on-page](https://github.com/lutz/PDFSplitAddon), click on [releases](https://github.com/lutz/PDFSplitAddon/releases) in the `Release` section and download the ZIP file of the add-on linked there.
4. Extract the add-on by right-clicking the ZIP file and clicking `Extract all`.
5. Copy all unzipped files into the directory `{installation directory of Citavi}\AddOns` (usually `C:\Program Files (x86)\Citavi 6\AddOns`). If you have not yet installed manual add-ons, you must first create the subfolder `Addons` yourself. <img width="766" alt="Add-on - PDFSplitAddon - Ansicht nach dem Kopieren der extrahierten Dateien" src="https://user-images.githubusercontent.com/31404555/115747883-f3c28c00-a395-11eb-91d8-26f34cde9be4.png">
6. Start Citavi 6 again and open you local project.
7. Add the edited book including the PDF file and all contributions you need, see [manual](https://www1.citavi.com/sub/manual6/en/index.html?101_adding_a_contribution_in_an_edited_book.html).
8. In the `Reference` tab of the edited book, right-click on the PDF file and click `Split PDF`. <img width="664" alt="Add-on - PDFSplitAddon - EN" src="https://user-images.githubusercontent.com/31404555/115747710-cd9cec00-a395-11eb-9566-8a17202dd40c.png">
9. Select the contributions for which a PDF should be created from the corresponding pages. Be sure to enter the physical page numbers if, for example, the book contains some page sections in Roman numerals or the logical pages (the printed page number on each page) differ for other reasons.
10. Click `OK`.

## Disclaimer

>There are no support claims by the company **Swiss Academic Software GmbH**, the provider of **Citavi** or other liability claims for problems or data loss. Any use is at your own risk. All rights to the name **Citavi** and any logos used are owned by **Swiss Academic Software GmbH**.

## License

This project is licensed under the [MIT](LICENSE) License.
