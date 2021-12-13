# Aplikace-NASA
Petr Barvík
| barvik.petr.2018@---.cz
| 16. 5. 2021

## Dokument SRS
* Úvod
  * Účel dokumentu
    * Účelem je vytvoření aplikace pro Android, která bude zobrazovat uživatům informace o tělesech v blízkosti Země
  * Kontakty
    * Barvík Petr | barvik.petr.2018@---.cz | tel. 111 111 111
* Celkový popis aplikace


  * Funkce
    * Aplikace bude zobrazovat informace o tělesech v blízkosti Země.
    * Uživatel bude tímto vědět, jaké objekty se pohybují v okolí Země
    * Program nebude ukládat data o uživateli
    * Aplikace bude zpracovávat otevřená data NASA ve formě JSON API
    * Tyto data se budou aktualizovat při dostupném datovém připojení
    * Pokud nebude připojení dostupné, použije poslední aktualizovaná data
    * Aplikace zobrazí poslední datum aktualizace těchto dat
  * Uživatelské skupiny
    * Jakýkoliv uživatel zařízení s Androidem
  * Omezení návrhu a implementace
    *  Zobrazení aplikace pouze na jednom zařízení
* Požadavky na rozhraní
  * Uživatelské rozhraní
    * Android aplikace
  * Softwarová rozhraní
    * Android
* Vlastnosti systému
  * Spuštění aplikace
    * Vstup: -
    * Akce: Aplikace získá data díky NASA API
    * Výstup: Zobrazení informací o tělesech v blízkosti Země
  * Aktualizovaní dat
    * Vstup: Aplikace sama aktualizuje data při datovém spojení s NASA servery
    * Akce: Aplikace si aktualizuje data
    * Výstup: Zobrazení aktualizovaných informací o tělesech v blízkosti Země
* Nefunkční požadavky
  * Výkonnost
    * Aplikace nebude vykreslovat a tím pádem zobrazovat vizuální interpretaci dat
  * Bezpečnost
    * Aplikace je bezpečná, aplikace nikam neposílá žádné data o uživateli
  * Spolehlivost
    * Aplikace používá internet a tudíž spolehlivost nikdy nebude 100%
    * Záleží na stavu serverů NASA a daném internetovém připojení


## Funkční specifikace
Verze 1.0.0

* Úvod
  * Účel dokumentu
    * Účelem je vytvoření Android aplikace, která bude zobrazovat objekty v blízkosti Země
  * Kontakty
    * Barvík Petr | barvik.petr.2018@---.cz | tel. 111 111 111
* Scénáře
  * Způsoby použití
    * Uživatel má možnost vidět v aplikaci objekty v blízkosti Země
    * Následně aplikace aktualizuje daná data o objektech, bez nutného vstupu uživatele
  * Typy uživatelských rolí - Personas
    * Všichni uživatelé mají stejné práva
  * Příklad
    * Uživatel spustí aplikaci a aplikace sama ukáže dané informace o objektech
    * Následně aplikace sama aktualizuje data, pokud bude navázané připojení k internetu
  * Vymezení rozsahu
    * Program nebude posílat žádné data na internet, ani do cloudového úložiště
    * Aplikace avšak bude stahovat data pomocí JSON API z NASA serverů
* Celková hrubá architektura
  * Pracovní tok
    * Uživatel spustí aplikaci
    * Aplikace se spojí s NASA servery pomocí JSON API
    * Aplikace zobrazí informace o objektech v blízkosti Země
  * Všechny detaily
    * Aplikace se bude skládat z jednoho hlavního okna
    * Výpis informací
      * Seznam objektů a jejich informací
      * Bude záležet, kolik objektů aplikace zobrazí

