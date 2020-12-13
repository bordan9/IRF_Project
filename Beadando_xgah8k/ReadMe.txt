Tételkód: BACA

A projekt egy játékforgalmazó weboldal 2020. decemberi eladásairól készít kimutatást.
Az adatbázis tartalmazni fogja a webshopon árult termékeket, megrendelõ adatait, rendelési tételeket, kosár tartalmát.
A diagram vásárlási trendeket fogja ábrázolni a rendelési tételek alapján (x tengely: dátum, y tengely: eladási mennyiség).
Random szám generálás segítségével véletlenszerû idõintervallumok adatait jeleníthetjük me.


1. B,
Az adatbázis egy fikcionális, játékforgalmazó vállalat 1 havi rendelés forgalmának adatait tartalmazza.
Az adatbázis táblái: Megrendelo, Rendeles, Rendeles_tetel, Szallitas, Szamla, Termek.
A projekthez a Rendeles tábla adatai lesznek felhasználva.
A tábla tartalma: Rendeles_id, Login_fk, Szallitas_fk, Szamla_fk, Fizetes, Datum.

2. A,
A Rendeles tábla adataiból, az Adatrendezes() függvényben található LINQ lekérdezés segítségével kaptam meg azt, hogy december egyes napjain hány tranzakció történt.



