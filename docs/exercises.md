# Příklady

## 1. Zoradenie čisel
Na vstupe dostane program tri celé čísla, program vypíše
- najväčšie číslo
- priemer čísel
- zoradené čísla od najmenšieho po najväčšie

Príklad:  
Vstup: 45 34 90  
Výstup:  
Najväššie číslo: 90  
Priemer: 56,33  
Zoradené čísla: 34 45 90  

## 2. Vlastnosti čísla
Michal dostal na domácu úlohu pre číslo spočítať nasledujúce vlastnosti:  
- Je číslo deliteľné číslom 7 ale nie číslom 3?  
- Aký je ciferný súčet čísla?
- Aké ma číslo delitele?
- Je to prvočíslo?
- Aké je najbližšie väčšie prvočislo?

Napíšte program, ktorý je číslo na vstupe vypíše požadované vlastnosti.

Príklad:  
Vlastnosti čísla 28:  
Číslo 28 je deliteľné číslom 7, ale nie číslom 3.  
ciferný súčet: 10  
delitele: 2, 4, 7, 14  
číslo 28 nie je prvočislo  
najbližšie väčšie prvočíslo: 29  

## 3. Hra “Hádaj na aké číslo myslím” 
Peter chce napísať program, ktorý s ním bude hrať hru “Hádaj na aké číslo myslím”. 

Hra sa hrá nasledovne - program vyberie číslo od 1 do 100. Peter potom toto čislo háda, pričom program mu vždy odpovie či uhádol, alebo je číslo menšie resp. väčšie.

Príklad:  
Program: Myslím na číslo od 1 do 100  
Peter: 50  
Program: Číslo, na ktoré myslím je väčšie ako 50  
Peter: 60  
Proram: Číslo, na ktoré myslím je menšie ako 60.  
Peter: 52  
Program: Uhádol si!  

Zložitejšia varianta - Peter vymysí číslo a nechá hádať program. Program vypíše tip a Peter na vstupe zadá VIAC, MENEJ alebo UHADOL SI. Skúste napísať algoritmus, ktorý uhádne číslo na najviac 7-8 pokusov.

Program: Je to číslo 50?  
Peter: VIAC  
Program: Je to číslo 70?  
Peter: MENEJ  
Proram: Je to číslo 52?  
Peter: UHADOL SI  

## 4. Reťazce
Program dostane na vstupe reťazec - slovo, program vypíše: 
- dĺžku slova
- koľko obsahuje slovo samohlások - a,e,i,o,u
- ako sa slovo číta od konca.
- číta sa slovo od začiatku aj od konca rovnako?

Príklad 1:  
Vstup: radar  
Výstup:  
Dĺźka slova: 5  
Slovo radar obsahuje 2 samohlásky.  
Od konca sa slovo radar číta radar.  
Slovo radar sa číta od začiatku aj od konca rovnako.  

Príklad 2:  
Vstup: pokoj  
Výstup:   
Dĺźka slova: 5  
Slovo radar obsahuje 2 samohlásky.  
Od konca sa slovo pokoj číta jokop.  
Slovo pokoj sa nečíta od začiatku aj od konca rovnako.  

## 5. Fibonacciho čísla
Napište program, který pro dané N vypíše prvních N Fibonacciho čisel.
https://cs.wikipedia.org/wiki/Fibonacciho_posloupnost

Príklad:  
Vstup: 10  
Výstup:  
0 1 1 2 3 5 8 13 21 34  

## 6. Deň narodenia
Peter je zvedavy, v ktorý deň v týdni sa narodil. Pomožte mu a napište program, který pro datum vypíše odpovídající den v týdnu.

Příklad:  
Vstup: 24.12.2018   
Výstup: Ponděli  

Vstup: 27.1.2019  
Výstup: Neděle  

Hint: Použijte typ DataTime a jeho metodu DayOfWeek.


## 7. Súbory 1
Program dostane na vstupe súbor s číslami (každé číslo je na novom riadku). Program vypíše: 
- súčet čísel v súbore
- maximálne číslo
- průmer čísel
- jestli se nějaké číslo opakuje.


## 8. Súbory 2
Program dostane na vstupe súbor input.txt. Program vypíše:
- koľko obsahuje súbor písmen
- koľko obsahuje súbor slov (slovo delí od iného slova tečka, čárka, nový řádek nebo mezera)
- aké je najdhlšie slovo, ktoré súbor obsahuje?
- obsahuje súbor slovo “C#”

## 9. Súbory 3
Program dostane na vstup číslo N a potom N mien vo formáte “meno priezvisko”. 

Napíšte program, ktorý:
- zapíše mená do súboru 
- zápíše mená do súboru v abecednom poradí (primárně program třídí podľa příjmení, pak podle křestního jména.

Příklad:

Vstup:   
3  
Peter Novák  
Anna Malá  
Petra Malá  

Výstup v súbore:  
Anna Malá  
Petra Malá  
Peter Novák  

## 10. Šifrovanie
Napíšte program, ktorý dostane na vstupe súbor a zašifruje resp. dešifruje ho nasledovne
- šifrovanie - každé písmeno premení na nasledujúce písmeno v abecede (a->b, b->c, .., z->a)
- dešifrovanie - každé písmeno premení na predchádzajúce písmeno v abecede (a->z, b->a, c -> b, .., z->y)

Príklad:  
- text: dnes sviti slunce
- zašifrovaný text: eoft txjuj tmvodf

## 11. Permutace
Napíšte program, ktorý dostane na vstupe číslo N a vypíše všetky permutace čísel 1..N.

Príklad:  
Vstup: N=3  
Výstup:  
1 2 3  
1 3 2  
2 1 3  
2 3 1  
3 1 2  
3 2 1  

## 12. Bludiště
Petr se stratil v bludišti, pomocte mu najít cestu ven.  
Na vstupu dostane program bludiště ( x - stěna, . - chodba), Peter se nachází na pozici P a východ
z bludiště je na pozici V. 

Najdete cestu, jak se Petr (P) dostane k východu (V).
* jakoukoliv cestu
* nejkratší cestu


Přiklad:
Bludiště
```
xxxxxxxxxxxxxxxxx  
x..............Vx  
x.x.x.xxxxxx.xxxx  
x.xxx.xx.......xx  
x........xx.x.xxx  
xx.xxxxx.Pxxxxxxx  
xxxxxxxxxxxxxxxxx  
```

Libovolná cesta (označena *)
```
xxxxxxxxxxxxxxxxx  
x**************Vx  
x*x.x.xxxxxx.xxxx  
x*xxx.xx.......xx  
x********xx.x.xxx  
xx.xxxxx*Pxxxxxxx  
xxxxxxxxxxxxxxxxx  
```

Nejkratší cesta (označena *)
```
xxxxxxxxxxxxxxxxx  
x...........***Vx  
x.x.x.xxxxxx*xxxx  
x.xxx.xx*****..xx  
x.......*xx.x.xxx  
xx.xxxxx*Pxxxxxxx  
xxxxxxxxxxxxxxxxx  
```

