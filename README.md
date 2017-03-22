# PROJEKTNI ZADATAK
# TEMA: iGym

1. Hana Helja
2. Harun Grabus
3. Lamija Hadžihasanović

## Opis teme
Naš sistem nudi raznovrsne programe vježbanja i ishrane za postizanje željnog izgleda tijela za svakog člana teretane. U ponudi su programi za mršanje,fitnes, dobijanje mišićne mase te mnogi drugi. Vježbe se mogu izvoditi kod kuće i u teretani, te je dat detaljan opis i video uz svaku vježbu kako bi lakše razumjeli način izvođenja, te svrhu svake vježbe.Ishrana igra važnu ulogu u postizanju željenih rezultata, te tako naš sistem nudi odgovarajući plan  ishrane prema odabiru programa vježbanja. Također, u sklopu ovog sistema se nalaze i dodatne upute i informacije kako bi Vaš put u ostvarivanju željenih rezultata prošao što brže i lakše.

## Procesi
### Registracija novog člana teretane
Uposlenik unosi podatke o novom članu(ime, prezime, datum rođenja, adresa stanovanja, broj telefona, e-mail). Također uposlenik fotografiše novog člana i sprema tu fotografiju zajedno s njegovim podacima radi identifikacije priliskom ulaska u teretanu. Nakon unosa podataka za novog člana se generiše registracijski broj, njegov username, šifra za pristup aplikaciji. Pristupne podatke uposlenik zatim daje članu. Potom se obračunava iznos mjesečne članarine, provjerava se da li novi član ima pravo na popust nakon čega slijeđi obračunavanje popusta, omogućeno je i rezervisanje termina grupnih vježbi i personalnih trenera što utječe na iznos mjesečne članarine. Član plaća članarinu za tekući mjesec, zaposlenik unosi informacije o uplaćenom iznosu, datumu uplate. Član dobija člansku karticu i prilikom ulaska u teretanu provlači je kroz aparat.

### Ulazak u teretanu
Član pri ulazu u teretanu provlači karticu ili svoje podatke(ime i prezime) daje uposleniku, u slučaju da je zaboravi. Nakon provlačenja kartice odnosno unosa podataka, sistem provjerava da li je članu omogućen pristup tj. da li je on doista član(postoji u bazi podataka i da li je to uistinu njegova kartica-po slici). Nakon toga provjerava se članarina. Ako član nije uplatio članarinu izbacuje se upozorenje koje uposlenik prenosi članu, pa je član dužan uplatiti prije pristupa teretani. Članarina traje 30 dana i to od dana uplate(npr. Od 10 januara do 10 februara). Ako član prođe navedene kontrole dozvoljen mu je pristup teretani.

### Korištenje  aplikacije
Korisnik unosi pristupne podatke koje je dobio prilikom učlanjivanja u teretani, te se vrši provjera da li je on zaista član teretane. Ukoliko mu je to prvi put prijavljivanja u aplikaciju korisniku će biti zatraženi podaci za popunjavanje njegovog profila. Ti podaci uključuju njegovu visinu, masu, cilj njegovog programa. Nakon odabira programa i dopunjavanja profila, korisniku se nudi plan vježbanja, ishrana za odgovarajući program te dodatne upute i informacije. Ukoliko se izabere prva opcija, prikazuje se plan vježbanja za svaki dan u sedmici na način da se svaki dan rade vježbe za različitu grupu mišića. Uz svaku vježbu se nalazi opis iste, te video koji pokazuje tačan način izvođenja. Također prikazuje se broj ponavljanja vježbi, te vrijeme za relaksaciju mišića. Na dodatnoj fotografiji je također prikazano koji se mišići aktiviraju prilikom izvođenja odgovarajuće vježbe.
Ukoliko korisnik u aplikaciji izabere opciju savjeti, bit će mu predstavljeni pojedini savjeti iz svijeta fitnessa i tjelovježbe.Ukoliko korisnik opciju ishrane bit će mu ponuđeni planovi ishrane, recepti za obroke i savjeti vezani za promjene u njegovoj ishrani koje će mu pomoći da dostigne svoj prethodno definirani cilj.

### Rezervacija termina grupnih vježbi
Klijent ima mogućnost rezervacije termina grupnih vježbi. Sala u  kojoj se izvode vježbe može primiti samo određen broj ljudi. Za svaki dan postoji nekoliko termina. Korisnik označi željeni termin te potvrdi unos. Ukoliko  je termin popunjen, prikazuje se obavijest o tome. 

### Vođenje bilješki u toku programa
Član teretane ima mogućnost vođenja bilješki tokom programa. Kada se otvori profil korisnika, nudi se mogućnost bilježenja promjene težine, te mogućnost vođenja evidencije o zdravstevnom stanju u toku programa.

### Plaćanje putem aplikacije
Korisnik može izvršiti uplatu za odgovarajući mjesec putem aplikacije. Nakon sto se korisnik prijavi, prikazuje se dodatna opcija prikaza njegovog profila. U okviru toga, član teretane može izvršiti uplatu.  Nakon što se unesu svi potrebni podaci za plaćanje,  slijedi provjera podataka. Ako su podaci validni onda se šalju eksternom sistemu koji treba da odobri ili odbije transakciju plaćanja.

## Funkcionalnosti
- mogućnost korištenja teretane
- mogućnost pristupa aplikaciji koja pomaže u postizanju željenih rezultata
- mogućnost odabira programa vježbanja
- plan ishrane prema izabranom programu vježbanja
- prikaz dodatnih informacija i uputa za svaki program
- mogućnost prijave korisnika putem barkoda na članskoj kartici
- mogućnost odabira opcije grupnih treninga i personalnog trenera
- mogućnost plaćanja gotovinom ili karticom
- svi programi nude plan vježbi za svaki dan u sedmici, pri čemu se svaki dan rade vježbe za drugu grupu mišića
- uz svaku vježbu se nalazi detaljan opis iste te video koji pomaže da se vježba izvede na pravilan način
- uz video su priložene fotografije na kojima su označeni mišići koji se aktiviraju prilikom izvođenja odgovarajuće vježbe
- mogućnost plaćanja putem aplikacije
- mogućnost rezervacije termina grupnih vježbi
- mogućnost vođenja bilješki prilikom izvodjenja programa(unos tezine, te mogućih popratnih efekata)
- mogućnost obračunavanja popusta na osnovu određenih kriterija 

## Akteri
1. Korisnik usluga( Klijent, Online klijent)- Korisnik usluga je osoba koja ima mogućnost korištenja teretane (klijent) i pristup aplikaciji gdje  ima svoj program vježbanja (online klijent).
2. Uposlenik - Uposlenik je osoba koja radi u teretani, na recepciji. Uposlenikradi na poslovima upisivanja novih članova, naplaćivanja, te izdavanja članskih kartica
3. Trener-Trener vodi grupne vježbe
4. Sistem za kontrolu uplate članarina-prilikom prijave člana provjerava da li je uplaćena članarina za tekući mjesec i daje upozorenje ukoliko je potrebno uplatiti članarinu
5. Sistem za uplatu članarina putem aplikacije



