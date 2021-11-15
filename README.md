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
