# Pomocník pro poštovního doručovatele

Vytvořte program, který pro poštovního doručovatele vytiskne dva důležité přehledy:

1. Jaké má komu odnést zásilky a kolik za to má získat peněz
2. Komu má doručit jaké cennosti

Pozn: Pro usnadnění modelu u nás platí příjemce zásilky při jejím doručení.

## K dispozici máte:
1. Diagram tříd a rozhraní
2. Screenshot s výsledkem testovacího kódu

## Jak je počítána cena doručení zásilky:
* Postcard - 2
* Letter - 10 (+10 je-li doporučený)
* Package - 100 + váha (+10 je-li doporučený)
* ValuableLetter - jako Letter + 1/10 hodnoty
* ValuablePackage - jako Package + 1/10 hodnoty

## Struktura tříd
![Třídy](/classes.jpg)

## Screenshot výsledku
![Výsledek](/screenshot.jpg)
