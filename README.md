# CSharp2_LB_DU1_Lucistnik
Konzolová aplikace simulující lučištníka střílejícího šípy, přidávajícího šípy do toulce a zjištění množství šípů.

Zadání:

Cíl: Vytvořit konzolovou aplikaci simulující lučištníka, se kterým může uživatel interagovat prostřednictvím jednoduchého menu.
Zaměření: Návrh a implementace třídy, použití metod a vlastností, vytvoření menu, základní práce s cykly, podmínkami a uživatelským vstupem.
Požadavky: Pro úspěšné dokončení tohoto úkolu váš kód musí obsahovat: switch, while, samostatnou třídu class(v našem případě lučišník), která bude volána z hlavní main metody, int.TryParse(vstup, out cislo) pro získání čísla pro doplnění šípů. 
Struktura Úkolu:

    Třída Lucistnik:
        Definujte public třídu Lucistnik.
        Vlastnosti: Třída by měla uchovávat informace o lučištníkovi:
            Jmeno (typ string)
            PocetSipu (typ int)

        Konstruktor: Vytvořte konstruktor (public Lucistnik(...)), který při vytváření instance lučištníka nastaví jeho Jmeno a počáteční PocetSipu podle předaných argumentů.

        Metoda Vystrel():
            Implementujte public void metodu Vystrel.
            Co má dělat: Pokud má lučištník dostatek šípů, sníží jejich počet o jeden a vypíše zprávu o úspěšném výstřelu. Pokud šípy nemá, vypíše odpovídající zprávu.

        Metoda PridejSipy(int pocet):
            Implementujte public void metodu PridejSipy, která přijímá počet šípů k přidání.
            Co má dělat: Zvýší lučištníkovi PocetSipu o zadaný pocet (mělo by fungovat jen pro kladný počet). Vypíše zprávu o výsledku akce.

        Metoda ZobrazStav():
            Implementujte public void metodu ZobrazStav.
            Co má dělat: Vypíše na konzoli aktuální jméno lučištníka a jeho počet šípů.

    Třída Program a Metoda Main:
        V metodě Main vytvořte jednu instanci třídy Lucistnik pomocí jejího konstruktoru.
        Implementujte hlavní smyčku programu (např. pomocí while(true)), která bude opakovaně:
            Zobrazovat aktuální stav lučištníka (zavoláním metody ZobrazStav).
            Prezentovat uživateli textové menu s následujícími volbami:
                Vystřelit šíp
                Přidat šípy
                Konec
            Načíst volbu uživatele z konzole.
            Zpracovat volbu (pomocí switch nebo if/else if):
                Při volbě 1: Zavolat metodu Vystrel na instanci lučištníka.
                Při volbě 2: Získat od uživatele počet šípů k přidání (viz bod 3) a zavolat metodu PridejSipy na instanci lučištníka s tímto počtem.
                Při volbě 3: Ukončit program.
                Pro neplatné volby: Zobrazit chybovou hlášku.

    Pomocná Metoda pro Načtení Čísla:
        Vytvořte ve třídě Program public static int metodu NactiCeleCisloZKonzole(string vyzva).

        Co má dělat: Tato metoda by měla bezpečně načíst celé číslo od uživatele. Měla by opakovaně vyzývat k zadání, dokud uživatel nezadá platné celé číslo (a ideálně by měla odmítnout záporné hodnoty, pokud to dává smysl pro kontext, kde se používá - např. přidávání šípů). Metoda vrátí validní načtené číslo.

