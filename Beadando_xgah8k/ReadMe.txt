T�telk�d: BACA

A projekt egy fikcion�lis j�t�kforgalmaz� weboldal 2020. decemberi elad�sair�l k�sz�t kimutat�st.

1. B,
Az adatb�zis egy fikcion�lis, j�t�kforgalmaz� v�llalat 1 havi rendel�s forgalm�nak adatait tartalmazza.
Az adatb�zis t�bl�i: Megrendelo, Rendeles, Rendeles_tetel, Szallitas, Szamla, Termek.
A projekthez a Rendeles t�bla adatai lesznek felhaszn�lva.
A t�bla tartalma: Rendeles_id, Login_fk, Szallitas_fk, Szamla_fk, Fizetes, Datum.

2. A,
A Rendeles t�bla adataib�l, a Diagramfeltoltes() f�ggv�nyben tal�lhat� LINQ lek�rdez�s seg�ts�g�vel kaptam meg azt, hogy december egyes napjain h�ny tranzakci� t�rt�nt.
A v�letlen nap adat�nak meghat�roz�s�n�l is LINQ lek�rdez�st haszn�ltam.

3. C,
A vonaldiagram december h�nap rendel�s forgalm�nak alakul�s�t �br�zolja.
x tengely: eltelt napok
y tengely: egy napon h�ny trancakci� t�rt�nt

4. A,
V�letlensz�m gener�l�s seg�ts�g�vel oldottam meg a funkci�t, amellyel inform�ci�t lehet szerezni egy v�letlenszer� napon be�rkez� rendel�sek sz�m�r�l.



