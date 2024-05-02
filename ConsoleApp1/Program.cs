// See https://aka.ms/new-console-template for more information

        HashSet<string> animali = new HashSet<string>()
        {
            "Cane", "Gatto", "Elefante", "Leone"
        };

        // Rimuovo l'animale "Elefante" dall'HashSet
        animali.Remove("Elefante");

        Console.WriteLine("HashSet aggiornato:");
        foreach (var animale in animali)
        {
            Console.WriteLine(animale);
        }
