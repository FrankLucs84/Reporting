# 📊 Reporting Power BI su database Contoso

## Descrizione del progetto
Proviamo a creare un report in Power BI partendo dal database Contoso disponibile su SQL Server.  
Con la definizione delle opportune relazioni tra le tabelle, realizzeremo un'analisi di Pareto finalizzata a identificare i principali driver di valore (es. clienti, prodotti, negozi).

## Obiettivi principali
- Importare e modellare i dati dal database Contoso.
- Creare un modello star schema normalizzato (fattori e dimensioni).
- Sviluppare misure DAX per il calcolo di vendite, margine e pareto cumulativo.
- Costruire visualizzazioni in Power BI (grafici Pareto, KPI card, tabelle dinamiche).

## Struttura del database utilizzato
Le tabelle principali utilizzate nel progetto sono:
- `Sales` (tabella dei fatti)
- `Customer` (dimensione clienti)
- `Product` (dimensione prodotti)
- `Store` (dimensione punti vendita)
- `Date` (dimensione calendario)

## Analisi implementate
- Vendite totali e costo totale.
- Margine lordo e percentuale di margine.
- Pareto Analysis sui clienti basata su:
  - Volume di vendita.
  - Quantità acquistata.
- KPI dinamici per monitorare performance per categoria prodotto e per filiali.

## Tecnologie e strumenti
- **Power BI Desktop** (versione consigliata: 2024 o successiva).
- **Tabular Editor 2** per gestione avanzata di misure e ottimizzazione del modello.
- **SQL Server Management Studio (SSMS)** per interrogazioni dati.
- **DAX Studio** per il debug e analisi delle query DAX.

## Come eseguire il progetto
1. Connettersi al database Contoso tramite Power BI Desktop.
2. Selezionare le tabelle indicate nella sezione *Struttura del database*.
3. Definire le relazioni tra le tabelle (es. `Sales[CustomerKey] → Customer[CustomerKey]`).
4. Creare le misure DAX previste.
5. Progettare e pubblicare il report.
