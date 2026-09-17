# Student Projects Management System

Desktop aplikacija za upravljanje projektima i prijavama studenata na projekte, razvijena u C# WinForms tehnologiji.


## Napomena

Ovaj projekat predstavlja rješenje **ispitnog primjera** iz predmeta **Programiranje III**.

Osnovni zahtjevi i funkcionalnosti projekta definisani su kroz ispitni primjer koji je objavio

- Profesor: **dr. sc. Denis Mušić**
- GitHub: **https://github.com/denis-music/cs-winforms-exam-template-2025-26**


## O projektu

Aplikacija omogućava evidenciju studenata, projekata i prijava studenata na projekte.

Korisnik kroz aplikaciju može pregledati postojeće prijave, pretraživati i filtrirati podatke, dodavati nove projekte i prijave, uređivati postojeće prijave.

Aplikacija takođe sadrži različite validacije kojima se osigurava ispravan unos podataka.

## Glavne funkcionalnosti

- pregled prijava studenata na projekte
- pretraga prijava prema imenu i prezimenu studenta
- pretraga prema nazivu projekta
- filtriranje prijava prema statusu prijave
- filtriranje prema stanju prijave
- dodavanje novih projekata
- dodavanje novih prijava studenata na projekte
- izmjena postojećih prijava
- generisanje prijava za dostupne projekte
- kreiranje izvještaja
- validacija podataka prilikom unosa i izmjene
- prikaz i upravljanje podacima iz SQLite baze


## Tehnologije

Projekat je razvijen korištenjem sljedećih tehnologija i alata:

- **C#**
- **.NET**
- **Windows Forms**
- **Entity Framework Core**
- **SQLite**
- **Visual Studio**
- **Git**
- **GitHub**

## Arhitektura projekta

Projekat je organizovan kroz više slojeva kako bi se odvojili rad sa podacima, poslovna logika i korisnički interfejs.

### Studentska.Data

Sloj zadužen za rad sa bazom podataka i definisanje modela odnosno entiteta koji se koriste u aplikaciji.

### Studentska.Servis

Sadrži servisne klase koje implementiraju poslovnu logiku aplikacije i omogućavaju komunikaciju između korisničkog interfejsa i sloja za pristup podacima.

### Studentska.WinApp

Windows Forms aplikacija koja predstavlja korisnički interfejs i omogućava korisniku rad sa studentima, projektima i prijavama.


## Baza podataka

Za čuvanje podataka koristi se **SQLite** baza podataka.

Glavni entiteti koji se koriste u aplikaciji su:

- `Studenti`
- `Projekti`
- `StudentiProjekti` (predstavlja **prijave**, vezu između entiteta `Studenti` i `Projekti`)


Baza podataka se nalazi u okviru aplikacije i koristi se za trajno čuvanje podataka potrebnih za rad sistema.


## Rad sa projektima

Aplikacija omogućava dodavanje novih projekata kroz posebnu formu.

Prilikom dodavanja projekta unose se podaci kao što su:

- naziv projekta
- napomena
- rok završetka
- maksimalan broj studenata
- status aktivnosti projekta
- logo projekta

Projekat može biti aktivan ili neaktivan, što utiče na njegovu dostupnost prilikom kreiranja novih prijava.


## Rad sa prijavama

Korisnik može dodati novu prijavu studenta na odabrani projekat.

Prilikom kreiranja prijave odabiru se:

- student
- projekat
- datum prijave
- status prijave


Prilikom izmjene postojeće prijave određena polja mogu biti ograničena u zavisnosti od trenutnog statusa prijave, čime se osigurava ispravan tok promjene statusa.


## Pretraga i filtriranje

Aplikacija sadrži formu za pregled i pretragu prijava.

Podaci se mogu filtrirati prema:

- imenu i prezimenu studenta
- nazivu projekta
- statusu prijave
- stanju prijave

Rezultati se prikazuju u tabelarnom obliku pomoću `DataGridView` kontrole.


## Validacija podataka

Prilikom rada sa aplikacijom provjeravaju se različiti uslovi kako bi se spriječio neispravan unos podataka.

Validacije uključuju, između ostalog:

- obavezna polja
- ispravnost unesenih vrijednosti
- dostupnost projekta
- maksimalan broj studenata na projektu
- postojanje postojećih prijava
- dozvoljene promjene statusa
- rok završetka projekta

Na ovaj način aplikacija sprječava situacije koje nisu dozvoljene definisanim pravilima sistema.


## Generisanje prijava

Aplikacija omogućava automatsko generisanje prijava za studenta.

Prilikom generisanja provjeravaju se uslovi koji određuju da li određeni projekat može biti ponuđen studentu.

Generisane prijave se prikazuju korisniku kroz informativni dio forme, gdje se može pratiti koje su prijave uspješno dodane.



## UML i analiza sistema

Pored implementacije aplikacije, urađena je i analiza sistema kroz UML dijagrame.

Za izradu analize i dijagrama korišteni su materijali sa predmeta **Analiza i dizajn softvera**.

- Profesorica: **dr. sc. Emina Junuz**
- Materijali: **dostupni materijali sa fakulteta!!!!**

U okviru analize sistema obrađeni su:

- domen sistema
- ključni entiteti i njihovi odnosi
- korisnik i sistem
- tokovi komunikacije
- procesi koji se izvršavaju u aplikaciji

### UML dijagrami

- Use Case
- Domain Model
- Sistem sekvencijalni dijagram
- Dijagram klasa
- Sekvencijalni dijagram
- Dijagram stanja
- Kolaboracijski dijagram
- Dijagram aktivnosti
- Dijagram komponenti
- Dijagram rasporeda

