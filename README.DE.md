# PDFSplitAddon

Dieses Add-on fügt dem Kontextmenü lokaler PDF-Dateien eine neue Funktion hinzu. Mit dieser Funktion können Sie bei den PDF-Dateien eines übergeordneten Werks die einzelnen Abschnitte für die untergeordneten Titel ausschneiden.

## Veröffentlichungen 

Die kompilierte Bibliothek finden Sie unter [releases](./../../releases) als Archiv. 

## Anwendung

Hinweis: Dieses Add-On kann nur mit lokalen (!) Projekten verwendet werden, nicht mit Cloud-Projekten. Es ist auch wichtig zu wissen, dass dieses Add-On nur bei übergeordneten Werken, die untergeordnete Titel besitzen, verwendet werden kann. Dieses Add-On extrahiert die erforderlichen Seiten aus dem gesamten PDF des Buches und weist sie jedem Beitrag als Anhang zu. Den Seitenbereich der Beiträge erfassen Sie bitte zuvor jeweils beim Beitrag im Feld `Seiten von-bis`.

Bitte gehen Sie folgendermaßen vor:

1. Falls noch nicht geschehen bzw. Sie mit einer älteren Citavi-6-Version arbeiten, nehmen Sie das Update auf die aktuelle Version von Citavi vor. Wenn das Update nicht automatisch angeboten wird, können Sie das aktuelle Setup unter https://www.citavi.com/download herunterladen und direkt installieren (eine vorherige Deinstallation ist nicht notwendig). Alle mit Citavi gesammelten Daten bleiben unverändert. Sie können auch [hier](https://www.citavi.com/beta) nachsehen, ob eine Beta-Version verfügbar ist, die alle neuesten Fehlerkorrekturen enthält.
2. Schließen Sie Citavi.
3. Klicken Sie auf der [Add-on-Seite](https://github.com/lutz/PDFSplitAddon) im Abschnitt `Release` auf den Link [releases](https://github.com/lutz/PDFSplitAddon/releases) und laden die dort verlinkte ZIP-Datei des Add-ons herunter.
4. Führen Sie auf der heruntergeladenen ZIP-Datei einen Rechtsklick aus und wählen Sie `Alle extrahieren`, um die Datei zu entpacken.
5. Kopieren Sie alle entpackten Dateien in das Verzeichnis `{Installationsverzeichnis von Citavi}\AddOns` (normalerweise `C:\Program Files (x86)\Citavi 6\AddOns`). Wenn Sie noch keine manuellen Add-ons installiert haben, müssen Sie den Unterordner `AddOns` zunächst selbst anlegen. Anschließend sollte es folgendermaßen aussehen: <img width="766" alt="Add-on - PDFSplitAddon - Ansicht nach dem Kopieren der extrahierten Dateien" src="https://user-images.githubusercontent.com/31404555/115750654-af84bb00-a398-11eb-98be-2e330e8e393a.png">
6. Starten Sie Citavi wieder und öffnen Sie Ihr lokales (!) Projekt.
7. Nehmen Sie das Sammelwerk inkl. der PDF-Datei und alle erwünschten Beiträge daraus auf, falls noch nicht geschehen, s. [Handbuch](https://www1.citavi.com/sub/manual6/de/index.html?101_adding_a_contribution_in_an_edited_book.html)
8. Führen Sie beim übergeordneten Sammelwerk im Reiter `Titel` ganz unten auf dem PDF-Dokument einen Rechtsklick aus und klicken Sie im Kontextmenü auf den Eintrag `PDF teilen`. <img width="664" alt="Add-on - PDFSplitAddon - DE" src="https://user-images.githubusercontent.com/31404555/115750674-b6133280-a398-11eb-9eed-bd7b99720ca8.png">
9. Wählen Sie die Beiträge aus, für die ein PDF anhand der ausgewählten Seiten erstellt werden soll. Achten Sie darauf, die physischen Seitenzahlen einzugeben, wenn das Buch z.B. einige Seitenabschnitte in römischen Zahlen enthält oder die logischen Seiten (die gedruckte Seitenzahl auf jeder Seite) aus anderen Gründen abweichen.
10. Klicken Sie `OK`.

## Disclaimer

> Es bestehen keine Supportansprüche gegenüber dem Unternehmen **Swiss Academic Software GmbH**, dem Anbieter von **Citavi**, oder andere Haftungsansprüche für Probleme oder Datenverlust. Jede Verwendung erfolgt auf eigenes Risiko. Alle Rechte an dem Namen **Citavi** und den verwendeten Logos liegen bei der **Swiss Academic Software GmbH**. 

## License

Dieses Projekt ist unter der [MIT](LICENSE)-Lizenz lizenziert.
