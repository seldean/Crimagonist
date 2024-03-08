using UnityEngine;
using System.Collections.Generic;
using OutputController;

#region Rules
public static class CharacterCapacities
{
    public const ushort LEVEL_CAP = 30000;
    public const uint LEVEL_XP_CAP = 1000000;
    public const ushort RENOWN_CAP = 1000;
    public const ushort DEPENDABILITY_CAP = 1000;
    public const byte WANTED_LEVEL_CAP = 10;
    public const byte FOCUS_CAP = 9;

    public const byte SKILLS_CAP = 250;
    public const byte SKILLS_XP_CAP = 100;
}
public static class CharacterAgeRules
{
    public const byte NATURAL_DEATH_START_AGE = 60;
    public const byte NATURAL_DEATH_PERCENT_DRIFT = 3;
}
public static class CharacterEventValues
{
    public const byte CHANCE_TO_GET_CAUGHT_PER_WANTED_LEVEL = 5;
}
public static class CharacterCreationSettings
{
    //NPC Amounts
    public const uint TOTAL_NPC_AMOUNT = ALL_FOCUSED_NPC_AMOUNT + BUSINESS_OWNER_AMOUNT + ROBBER_AMOUNT + HITMAN_AMOUNT + WORKER_AMOUNT + DEALER_AMOUNT + TRANSPORTER_AMOUNT + ACCOUNTANT_AMOUNT + ATTORNEY_AMOUNT + CONNECTOR_AMOUNT;
    public const uint ALL_FOCUSED_NPC_AMOUNT = 4000;
    public const uint BUSINESS_OWNER_AMOUNT = 1000;
    public const uint ROBBER_AMOUNT = 1000;
    public const uint HITMAN_AMOUNT = 1000;
    public const uint WORKER_AMOUNT = 1000;
    public const uint DEALER_AMOUNT = 1000;
    public const uint TRANSPORTER_AMOUNT = 1000;
    public const uint ACCOUNTANT_AMOUNT = 1000;
    public const uint ATTORNEY_AMOUNT = 1000;
    public const uint CONNECTOR_AMOUNT = 1000;
    //Rarity Settings for NPCs
    public const byte ULTRA_RARE_LIMIT = 98;
    public const byte RARE_LIMIT = 90;
    public const byte UNCOMMON_LIMIT = 60;
    public const byte RARITY_RANDOMIZER_MIN = 1;
    public const byte RARITY_RANDOMIZER_MAX = 101;
    //When worker becomes Scientist?
    public const uint WORKER_BECOMES_SCIENTIST_LEVEL_THRESHOLD = 15000;
    //Motherland and Currentlocation
    public const byte MOTHERLAND_INDEX_LIMIT = 20;
    public const byte CURRENT_LOCATION_INDEX_LIMIT = 100;
    //Woman percentage
    public const byte DEFAULT_WOMAN_PERCENTAGE = 50;
    public const byte BUSINESS_WOMAN_PERCENTAGE = 50;
    public const byte ROBBER_WOMAN_PERCENTAGE = 20;
    public const byte HITMAN_WOMAN_PERCENTAGE = 50;
    public const byte WORKER_WOMAN_PERCENTAGE = 1;
    public const byte DEALER_WOMAN_PERCENTAGE = 1;
    public const byte TRANSPORTER_WOMAN_PERCENTAGE = 5;
    public const byte ACCOUNTANT_WOMAN_PERCENTAGE = 75;
    public const byte ATTORNEY_WOMAN_PERCENTAGE = 50;
    public const byte CONNECTOR_WOMAN_PERCENTAGE = 10;
    //Is NPC Prisoned at the start
    public const float NPC_IMPRISONED_CHANCE = 0.5f;
    //Is NPC Running at the start
    public const float NPC_RUNNING_CHANCE = 0.5f;
}
public static class CharacterNamesAndSurnames {
    public static readonly string[] AmericanMaleNames = {
    "James", "John", "Robert", "Michael", "William", "David", "Joseph", "Charles", "Thomas", "Daniel",
    "Matthew", "Anthony", "Donald", "Mark", "Paul", "Steven", "Andrew", "Kenneth", "George", "Joshua",
    "Kevin", "Brian", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Frank", "Scott", "Eric",
    "Stephen", "Jerry", "Gregory", "Raymond", "Samuel", "Patrick", "Benjamin", "Dennis", "Peter", "Larry",
    "Terry", "Roger", "Gary", "Douglas", "Henry", "Carl", "Arthur", "Ryan", "Joe", "Jonathan",
    "Justin", "Albert", "Troy", "Christian", "Bryan", "Adam", "Shawn", "Sean", "Jesse", "Travis",
    "Jeremy", "Ralph", "Brandon", "Billy", "Aaron", "Philip", "Chad", "Todd", "Walter", "Darrell",
    "Jay", "Luis", "Keith", "Lawrence", "Kyle", "Roy", "Willie", "Fred", "Eugene", "Peter",
    "Craig", "Alan", "Randy", "Billy", "Howard", "Arthur", "Clarence", "Jeremiah", "Leonard", "Bradley",
    "Antonio", "Edwin", "Don", "Carlos", "Gerald", "Glenn", "Tony", "Vincent", "Bobby", "Curtis",
    "Victor", "Dale", "Derek", "Ricky", "Jared", "Alberto", "Lance", "Dwayne", "Cory", "Eddie"
    };
    public static readonly string[] AmericanFemaleNames = {
    "Mary", "Jennifer", "Linda", "Patricia", "Susan", "Jessica", "Sarah", "Karen", "Nancy", "Lisa",
    "Margaret", "Betty", "Sandra", "Ashley", "Dorothy", "Kimberly", "Emily", "Donna", "Michelle", "Carol",
    "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Laura", "Helen", "Sharon", "Cynthia", "Amy",
    "Angela", "Brenda", "Elizabeth", "Kathleen", "Anna", "Samantha", "Pamela", "Nicole", "Martha", "Christine",
    "Janet", "Andrea", "Carolyn", "Frances", "Heather", "Maria", "Diane", "Julie", "Joyce", "Victoria",
    "Kelly", "Christina", "Lauren", "Evelyn", "Alice", "Judith", "Catherine", "Jean", "Teresa", "Rachel",
    "Olivia", "Gloria", "Marie", "Martha", "Megan", "Danielle", "Diana", "Anne", "Molly", "Sara",
    "Janice", "Brooke", "Hannah", "Virginia", "Katherine", "Joan", "Louise", "Ruby", "Theresa", "Ruth",
    "Phyllis", "Peggy", "Wanda", "Erin", "Dawn", "Cheryl", "Charlotte", "Kathryn", "Judy", "Colleen",
    "Emily", "Abigail", "Lillian", "Natalie", "Wendy", "Marjorie", "Shirley", "Paula", "Grace", "Beverly",
    "Tracy", "Maureen", "Marilyn", "Jacqueline", "Sylvia", "Roberta", "Melanie", "Bonnie", "Vanessa", "Rosa"
    };
    public static readonly string[] AmericanSurnames = {
        "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas",
        "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee",
        "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez",
        "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart",
        "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward",
        "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross",
        "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster",
        "Gonzales", "Bryant", "Alexander", "Russell"
    };
    public static readonly string[] BritishMaleNames = {
    "James", "John", "Robert", "David", "William", "Andrew", "Michael", "Richard", "Matthew", "Christopher",
    "Daniel", "Peter", "Simon", "Paul", "Stephen", "Jonathan", "Anthony", "Mark", "Benjamin", "Nicholas",
    "Edward", "Alexander", "George", "Thomas", "Timothy", "Philip", "Charles", "Patrick", "Jeremy", "Martin",
    "Alan", "Ian", "Nigel", "Graham", "Adrian", "Roger", "Jason", "Duncan", "Francis", "Jeremy",
    "Trevor", "Keith", "Colin", "Gavin", "Stuart", "Malcolm", "Dominic", "Russell", "Gareth", "Jeffrey",
    "Terence", "Kenneth", "Douglas", "Marcus", "Christopher", "Samuel", "Martyn", "Donald", "Simon", "Justin",
    "Gregory", "Maurice", "Victor", "Leslie", "Frank", "Desmond", "Harold", "Sidney", "Leonard", "Bruce",
    "Carl", "Bryan", "Vincent", "Eugene", "Ronald", "Robin", "Leon", "Liam", "Gordon", "Benedict",
    "Arthur", "Clive", "Derek", "Iain", "Jeremy", "Lewis", "Malcolm", "Neville", "Oscar", "Piers",
    "Reuben", "Rodney", "Shane", "Stanley", "Tristan", "Wilfred", "Xavier", "Yusuf", "Zachary", "Harrison"
    };
    public static readonly string[] BritishFemaleNames = {
    "Elizabeth", "Sarah", "Emily", "Charlotte", "Sophie", "Olivia", "Grace", "Alice", "Jessica", "Lucy",
    "Hannah", "Ella", "Mia", "Amelia", "Chloe", "Lily", "Isabella", "Freya", "Eva", "Millie",
    "Evie", "Scarlett", "Ruby", "Poppy", "Phoebe", "Imogen", "Maisie", "Isabelle", "Rosie", "Florence",
    "Daisy", "Georgia", "Molly", "Ellie", "Anna", "Abigail", "Eleanor", "Megan", "Harriet", "Maddison",
    "Emma", "Zoe", "Amy", "Kate", "Sophia", "Matilda", "Nancy", "Layla", "Esme", "Amber",
    "Leah", "Cara", "Lydia", "Jasmine", "Milly", "Bethany", "Lottie", "Gracie", "Sienna", "Erin",
    "Rebecca", "Lola", "Willow", "Isla", "Ava", "Evelyn", "Charlotte", "Georgia", "Katie", "Sofia",
    "Elsie", "Martha", "Harper", "Lara", "Rose", "Imogen", "Aria", "Eliza", "Bella", "Pippa",
    "Holly", "Penelope", "Luna", "Amelie", "Harmony", "Faith", "Darcie", "Thea", "Ayla", "Tilly",
    "Lyra", "Zara", "Violet", "Niamh", "Orla", "Clara", "Mabel", "Daisy", "Aurora", "Beatrix"
    };
    public static readonly string[] BritishSurnames = {
    "Smith", "Jones", "Williams", "Brown", "Taylor", "Davies", "Wilson", "Evans", "Thomas", "Johnson",
    "Roberts", "Walker", "Wright", "Robinson", "Thompson", "White", "Hall", "Clark", "Lewis", "Green",
    "Harris", "Cooper", "King", "Baker", "Hill", "Turner", "Parker", "Cook", "Edwards", "Morris",
    "Hughes", "Bell", "Ward", "Watson", "Morgan", "Davis", "Allen", "Young", "Bennett", "Carter",
    "Harrison", "Mitchell", "Murphy", "Scott", "Phillips", "Coleman", "Foster", "Reed", "Howard",
    "Mills", "Price", "Bailey", "Marshall", "Butler", "Barnes", "Stewart", "Perry", "Wood", "Brooks",
    "Russell", "Gray", "Turner", "Adams", "Kelly", "Cox", "Hughes", "Long", "Sullivan", "Graham",
    "Murray", "Collins", "Powell", "Simmons", "Fisher", "Moore", "Mitchell", "Campbell", "James",
    "Morris", "Bennett", "Foster", "Ward", "Richardson", "Roberts", "Anderson", "Watson", "Davis",
    "Lewis", "Gray", "Russell", "Coleman", "Howard", "Bell", "Sullivan", "Jenkins", "Owen", "Lee"
    };
    public static readonly string[] GermanMaleNames = {
    "Lukas", "Paul", "Leon", "Finn", "Maximilian", "Ben", "Felix", "Noah", "Jonas", "Elias",
    "Julian", "Luca", "Liam", "Alexander", "Nico", "Tim", "Moritz", "Tom", "David", "Simon",
    "Jan", "Philipp", "Jakob", "Eric", "Oskar", "Fabian", "Matteo", "Anton", "Henry", "Johannes",
    "Valentin", "Emil", "Tobias", "Sebastian", "Daniel", "Marlon", "Jonathan", "Raphael", "Niklas", "Samuel",
    "Theo", "Florian", "Hannes", "Christian", "Gabriel", "Mats", "Max", "Aaron", "Robert", "Kilian",
    "Dominic", "Kevin", "Adrian", "Benjamin", "Benedikt", "Leonard", "Justin", "Simon", "Marc", "Michael",
    "Christopher", "Andreas", "Dennis", "Nils", "Marvin", "Raphael", "Malte", "Alexander", "Nikolas", "Timothy",
    "Kai", "Nicolas", "Till", "Vincent", "Jonathan", "Fabio", "Lars", "Florian", "Marcel", "Roman",
    "David", "Jeremy", "Jonathan", "Samuel", "Tristan", "Jannis", "Josua", "Jonathan", "Oliver", "Maurice",
    "Nico", "Joshua", "Lennard", "Dominik", "Tom", "Leonhard", "Justus", "Julian", "Jannik", "Lukas"
    };
    public static readonly string[] GermanFemaleNames = {
    "Emma", "Hannah", "Emilia", "Mia", "Lena", "Anna", "Sophia", "Marie", "Lina", "Lea",
    "Mila", "Clara", "Luisa", "Laura", "Charlotte", "Amelie", "Emily", "Frieda", "Sophie", "Mathilda",
    "Johanna", "Ella", "Greta", "Lara", "Lotta", "Paula", "Maja", "Nora", "Mara", "Maria",
    "Sarah", "Nele", "Jana", "Alina", "Lia", "Isabella", "Helena", "Lena", "Elisa", "Livia",
    "Rosa", "Anni", "Helen", "Leona", "Lotte", "Victoria", "Melina", "Franziska", "Lisa", "Eva",
    "Leonie", "Julia", "Amalia", "Carla", "Antonia", "Luise", "Magdalena", "Sofia", "Isabel", "Selina",
    "Mina", "Ronja", "Tabea", "Leonora", "Elina", "Sara", "Elisabeth", "Tessa", "Elli", "Gloria",
    "Mira", "Melissa", "Jette", "Ina", "Fiona", "Celine", "Liv", "Zoe", "Frida", "Romy",
    "Pia", "Ida", "Anika", "Miriam", "Jasmin", "Hannah", "Cara", "Alicia", "Pauline", "Emely",
    "Jule", "Anna-Lena", "Felicitas", "Ayla", "Hanna", "Elif", "Jasmina", "Carlotta", "Emily", "Esther"
    };
    public static readonly string[] GermanSurnames = {
    "Müller", "Schmidt", "Schneider", "Fischer", "Weber", "Meyer", "Wagner", "Becker", "Schulz", "Hoffmann",
    "Schäfer", "Koch", "Bauer", "Richter", "Klein", "Wolf", "Schröder", "Neumann", "Schwarz", "Zimmermann",
    "Braun", "Krüger", "Hofmann", "Hartmann", "Lange", "Schmitt", "Werner", "Schmitz", "Krause", "Meier",
    "Lehmann", "Schmid", "Schulze", "Maier", "Köhler", "Herrmann", "König", "Walter", "Mayer", "Huber",
    "Kaiser", "Fuchs", "Peters", "Lang", "Scholz", "Möller", "Weiß", "Jung", "Hahn", "Schubert",
    "Vogel", "Friedrich", "Keller", "Günther", "Frank", "Berger", "Winkler", "Roth", "Beck", "Lorenz",
    "Baumann", "Franke", "Albrecht", "Schuster", "Simon", "Ludwig", "Böhm", "Winter", "Kraus", "Martin",
    "Schumacher", "Krämer", "Vogt", "Stein", "Jäger", "Otto", "Sommer", "Groß", "Seidel", "Heinrich",
    "Brandt", "Haas", "Schreiber", "Graf", "Schulte", "Dietrich", "Ziegler", "Kuhn", "Kühn", "Pohl",
    "Engel", "Hermann", "Sander", "Wolff", "Paul", "Ritter", "Freitag", "Horn", "Kraft", "Hübner"
    };
    public static readonly string[] FrenchMaleNames = {
    "Lucas", "Léo", "Louis", "Hugo", "Gabriel", "Arthur", "Jules", "Adam", "Raphaël", "Paul",
    "Alexandre", "Maxime", "Thomas", "Antoine", "Matéo", "Théo", "Noah", "Enzo", "Nathan", "Timéo",
    "Nicolas", "Mathis", "Éthan", "Tom", "Baptiste", "Clément", "Samuel", "Axel", "Victor", "Gaspard",
    "Sacha", "Léon", "Pierre", "Julien", "Tristan", "Édouard", "Damien", "Marc", "Augustin", "Quentin",
    "Rémi", "Charles", "Valentin", "Oscar", "Émile", "Maxence", "Benoît", "Lucien", "Romain", "Alexis",
    "Guillaume", "Matthieu", "Julian", "Sylvain", "Côme", "André", "Félix", "Marius", "Martin", "Grégoire",
    "Hector", "Thibault", "Bastien", "Fabien", "Stanislas", "Georges", "Corentin", "Antonin", "François", "Étienne",
    "Rémy", "Gilles", "Renaud", "Yves", "Vincent", "Arnaud", "Ludovic", "Cédric", "Denis", "Geoffrey",
    "Guilhem", "Hervé", "Jérémie", "Kévin", "Loïc", "Mickaël", "Olivier", "Patrick", "Stéphane", "Yannick",
    "Yvan", "Zacharie", "Bruno", "Didier", "Emmanuel", "Florent", "Gérard", "Hugues", "Ignace", "Jean-Paul"
    };
    public static readonly string[] FrenchFemaleNames = {
    "Emma", "Jade", "Louise", "Alice", "Chloé", "Léa", "Manon", "Inès", "Lola", "Julia",
    "Camille", "Lucie", "Clara", "Agathe", "Romane", "Rose", "Sarah", "Anaïs", "Émilie", "Amélie",
    "Charlotte", "Zoé", "Margaux", "Justine", "Lilou", "Mathilde", "Pauline", "Laura", "Maëlle", "Coline",
    "Lina", "Héloïse", "Elisa", "Lou", "Noémie", "Capucine", "Alicia", "Audrey", "Marie", "Élise",
    "Lucile", "Mélanie", "Olivia", "Sophie", "Céline", "Anaëlle", "Morgane", "Aurélie", "Lisa", "Marianne",
    "Laure", "Nina", "Salomé", "Léonie", "Juliette", "Margot", "Élodie", "Caroline", "Lise", "Mathilda",
    "Louison", "Soline", "Stéphanie", "Claire", "Éléonore", "Océane", "Emilie", "Léna", "Naomi", "Nathalie",
    "Lucienne", "Florence", "Lorraine", "Colette", "Sophie-Anne", "Anne-Sophie", "Martine", "Véronique", "Emmanuelle", "Agnès",
    "Angélique", "Danielle", "Fabienne", "Geneviève", "Hélène", "Isabelle", "Jacqueline", "Karine", "Magali", "Nadine",
    "Pascale", "Sylvie", "Valérie", "Yvette", "Zoélie", "Brigitte", "Célestine", "Delphine", "Édith", "Francine"
    };
    public static readonly string[] FrenchSurnames = {
    "Martin", "Bernard", "Dubois", "Thomas", "Robert", "Richard", "Petit", "Durand", "Leroy", "Moreau",
    "Simon", "Laurent", "Lefebvre", "Michel", "Garcia", "David", "Bertrand", "Roux", "Vincent", "Fournier",
    "Morel", "Girard", "Lambert", "Dupuis", "Fontaine", "Rousseau", "Andre", "Mercier", "Dupont", "Lefevre",
    "Lopez", "Gonzalez", "Leclerc", "Bonnet", "Francois", "Martinez", "Legrand", "Garnier", "Faure", "Remy",
    "Julien", "Marchand", "Philippe", "Gauthier", "Dubois", "Perrin", "Henry", "Dufour", "Robin", "Clement",
    "Morin", "Dumas", "Olivier", "Gaillard", "Bouchard", "Roche", "Giraud", "Colin", "Aubert", "Blanc",
    "Guerin", "Fabre", "Barbier", "Carpentier", "Meyer", "Brun", "Pierre", "Rey", "Lemoine", "Mathieu",
    "Duval", "Renaud", "Leroux", "Benoit", "Guillaume", "Dupuy", "Prevost", "Dubois", "Lecomte", "Riviere",
    "Leblanc", "Bertin", "Leclercq", "Leroux", "Joly", "Lucas", "Muller", "Rodriguez", "Fabre", "Rolland"
    };
    public static readonly string[] TurkishMaleNames = {
    "Ahmet", "Mehmet", "Mustafa", "Ali", "Ýbrahim", "Hüseyin", "Hasan", "Ömer", "Emre", "Yusuf",
    "Mert", "Can", "Murat", "Tolga", "Serkan", "Eren", "Berkay", "Kadir", "Tuncay", "Ýsmail",
    "Barýþ", "Volkan", "Adem", "Selim", "Cem", "Fatih", "Kaan", "Efe", "Uður", "Tahir",
    "Sedat", "Serdar", "Furkan", "Ýlker", "Orhan", "Yiðit", "Gökhan", "Yavuz", "Onur", "Halil",
    "Oðuz", "Hakan", "Metin", "Deniz", "Cihan", "Engin", "Ahmetcan", "Mahmut", "Erhan", "Tayfun",
    "Kerem", "Doðan", "Bülent", "Yasin", "Hamza", "Ramazan", "Cemal", "Salih", "Ayhan", "Osman",
    "Erdem", "Yalçýn", "Süleyman", "Rýza", "Kamil", "Fikret", "Ýsmet", "Mücahit", "Erdoðan", "Ýlhan",
    "Cengiz", "Celal", "Ýlyas", "Erdal", "Umut", "Tarýk", "Turgay", "Tarýk", "Utku", "Þevket",
    "Bedirhan", "Serkan", "Serhat", "Turan", "Yüksel", "Gürkan", "Cemil", "Muammer", "Ýsa", "Fahrettin",
    "Sertan", "Hikmet", "Cavit", "Adnan", "Halit", "Özgür", "Ferhat", "Rüstem", "Arda", "Özkan"
    };
    public static readonly string[] TurkishFemaleNames = {
    "Ayþe", "Fatma", "Emine", "Zeynep", "Hatice", "Meryem", "Havva", "Sultan", "Sümeyye", "Rabia",
    "Dilara", "Elif", "Gizem", "Ebru", "Ceren", "Esra", "Melike", "Ýrem", "Gülþah", "Buse",
    "Ýlayda", "Merve", "Bengü", "Nur", "Yasemin", "Aslý", "Sevgi", "Gül", "Melek", "Ezgi",
    "Aylin", "Tuðba", "Gülay", "Aysel", "Selin", "Pelin", "Ýpek", "Derya", "Büþra", "Nihan",
    "Damla", "Sevil", "Özlem", "Zeliha", "Hande", "Nazlý", "Ýclal", "Simge", "Ece", "Ayça",
    "Duygu", "Cansu", "Þeyma", "Hilal", "Nesrin", "Kübra", "Yaðmur", "Sude", "Ayten", "Özge",
    "Betül", "Sedef", "Leyla", "Ebru", "Perihan", "Pýnar", "Ýpek", "Dicle", "Özlem", "Hacer",
    "Sibel", "Gamze", "Esma", "Funda", "Feride", "Nurgül", "Müge", "Nalan", "Sevda", "Nevin",
    "Ayla", "Gülnur", "Lale", "Özden", "Zehra", "Serpil", "Ela", "Yasemin", "Reyhan", "Ayfer",
    "Meral", "Filiz", "Gizem", "Ahu", "Bilge", "Demet", "Gülþen", "Candan", "Ýlkay", "Selma"
    };
    public static readonly string[] TurkishSurnames = {
    "Yýlmaz", "Kaya", "Demir", "Çelik", "Yýldýrým", "Öztürk", "Balta", "Koç", "Þahin", "Çetin",
    "Özdemir", "Arslan", "Doðan", "Kara", "Aydýn", "Çalýþkan", "Aksoy", "Güler", "Aydemir", "Polat",
    "Türk", "Yalçýn", "Gül", "Çakýr", "Can", "Kýlýç", "Acar", "Keskin", "Taþ", "Yaman",
    "Akýn", "Çelik", "Durmaz", "Aktaþ", "Yavuz", "Akgün", "Ay", "Gündüz", "Topal", "Karabulut",
    "Sarý", "Turan", "Güler", "Kaplan", "Aslan", "Erbay", "Güneþ", "Akgül", "Karaçam", "Karadað",
    "Baþar", "Ýþçi", "Eren", "Gökçe", "Aksu", "Sözen", "Bulut", "Erdem", "Köse", "Arýcan",
    "Bozkurt", "Duman", "Kurtuluþ", "Özgür", "Ergün", "Þen", "Atýcý", "Yüksel", "Özkan", "Uzun",
    "Göktürk", "Bilgin", "Kýlýçaslan", "Sancak", "Ateþ", "Kutlu", "Güngör", "Köksal", "Yenigün", "Uður",
    "Ünal", "Erkan", "Canbaz", "Yýldýz", "Tunç", "Karagöz", "Çolak", "Ýlhan", "Çalýþ", "Yýlmazer",
    "Þenol", "Orhan", "Kocaman", "Kutluay", "Özmen", "Güçlü", "Sevinç", "Kabadayý", "Soylu", "Oflaz"
    };
    public static readonly string[] ChineseMaleNames = {
    "Wei", "Jian", "Jun", "Lei", "Ming", "Chen", "Hao", "Li", "Tao", "Xiang",
    "Yang", "Yu", "Zhang", "Wei", "Yuan", "Zheng", "Xu", "Zhi", "Sheng", "Yong",
    "Kang", "Feng", "Han", "Hong", "Jin", "Liang", "Nan", "Ping", "Qiang", "Rui",
    "Shi", "Tian", "Wen", "Xin", "Yan", "Zhen", "An", "Bo", "Cai", "Dong",
    "En", "Fu", "Gang", "Hai", "Jie", "Kai", "Long", "Mao", "Ning", "Peng",
    "Qing", "Ren", "Shan", "Tai", "Ulan", "Wang", "Xiao", "Yi", "Zhan", "Ao",
    "Bin", "Chang", "Dao", "Fan", "Gao", "He", "Jia", "Ke", "Lin", "Min",
    "Nuo", "Piao", "Quan", "Rong", "Shu", "Tao", "Ushi", "Wen", "Xue", "Yi",
    "Zai", "Bao", "Cong", "Ding", "Er", "Feng", "Guo", "Huang", "Jiang", "Kun",
    "Liu", "Meng", "Niu", "Pang", "Qiu", "Ru", "Shi", "Teng", "Wei", "Xie"
    };
    public static readonly string[] ChineseFemaleNames = {
    "Mei", "Jing", "Ling", "Xia", "Hua", "Yan", "Zhen", "Fang", "Li", "Xiu",
    "Rong", "Yun", "Wei", "Hui", "Hong", "Xiang", "Ying", "Juan", "Ming", "Lan",
    "Xiao", "Qing", "Jie", "Mei", "Yu", "Min", "Hui", "Ling", "Ping", "Fen",
    "Xia", "Na", "Zi", "Wei", "Qiu", "Yue", "Li", "An", "Chun", "Ya",
    "Man", "Yan", "Jing", "Shan", "Zi", "Wei", "Yu", "Feng", "Xin", "Lei",
    "Hui", "Jing", "Mei", "Ning", "Qing", "Xia", "Ya", "Ying", "Zhen", "Yu",
    "Xiu", "Wen", "Jin", "Lan", "Meng", "Qian", "Rui", "Shu", "Tian", "Wei",
    "Xin", "Yan", "Zi", "Bao", "Cai", "Dong", "Fang", "Guo", "Hui", "Jia",
    "Kun", "Lian", "Min", "Nuo", "Ping", "Qiao", "Ru", "Shi", "Ting", "Wei",
    "Xia", "Yi", "Zhen", "Ai", "Bei", "Cui", "Dai", "Fei", "Ge", "Huan"
    };
    public static readonly string[] ChineseSurnames = {
    "Li", "Wang", "Zhang", "Liu", "Chen", "Yang", "Zhao", "Huang", "Zhou", "Wu",
    "Xu", "Sun", "Ma", "Guo", "He", "Gao", "Lin", "Lu", "Wei", "Feng",
    "Deng", "Cao", "Xie", "Su", "Yu", "Tang", "Qin", "Jin", "Mo", "Yan",
    "Liang", "Song", "Cheng", "Yu", "Wei", "Pan", "Yao", "Yuan", "Xue", "Fu",
    "Gong", "Jiang", "Hao", "Dou", "Xiao", "Shi", "Zhu", "Long", "Zeng", "Wei",
    "Fang", "Xiong", "Zhong", "Gu", "Ren", "Jia", "Shen", "Zhuang", "Yin", "Xu",
    "Fu", "Qian", "Yue", "Jiang", "Ping", "Yi", "Xiang", "Hu", "Shao", "Mo",
    "Wei", "Qiu", "Yi", "Shi", "Gao", "Tian", "Mao", "Cai", "Tao", "Wen",
    "Tang", "Xing", "Wang", "Jiang", "Xiao", "Luo", "Dong", "Cheng", "Pan", "Hu"
    };
    public static readonly string[] JapaneseMaleNames = {
    "Hiroshi", "Yuki", "Kazuki", "Takashi", "Kenji", "Haruki", "Ryota", "Daiki", "Tatsuya", "Yuuki",
    "Takumi", "Satoshi", "Yuta", "Kaito", "Riku", "Shota", "Kota", "Kazuya", "Sho", "Kento",
    "Kosuke", "Yusuke", "Haru", "Haruto", "Ryota", "Yuya", "Kazuki", "Takahiro", "Yoshihiro", "Naoki",
    "Yoshinori", "Hideki", "Shinji", "Junichi", "Kazuo", "Ryosuke", "Tomohiro", "Hiroki", "Masashi", "Satoru",
    "Koji", "Makoto", "Tadashi", "Toshiro", "Hayato", "Kazuhiro", "Kenta", "Tatsuo", "Toshiaki", "Yasuhiro",
    "Yoshio", "Akihiro", "Noboru", "Tomoaki", "Atsushi", "Eiji", "Fumio", "Hirofumi", "Isamu", "Jiro",
    "Kazuhiko", "Masaaki", "Nobuyuki", "Susumu", "Takao", "Toshihiko", "Yasushi", "Yoichi", "Yukio", "Akira",
    "Daisuke", "Fumio", "Hiroaki", "Kazuhisa", "Makoto", "Norio", "Satoshi", "Takashi", "Toshio", "Yasuhiro",
    "Yoshikazu", "Akihiko", "Hidetoshi", "Ikuo", "Katsumi", "Masayuki", "Naoto", "Takayuki", "Toru", "Yasunori",
    "Yoshiaki", "Akio", "Eisuke", "Hirofumi", "Kazuhiro", "Masaaki", "Naoki", "Ryuji", "Shinichi", "Tadashi"
    };
    public static readonly string[] JapaneseFemaleNames = {
    "Yui", "Hana", "Sakura", "Aoi", "Yuna", "Rina", "Miyu", "Akari", "Haruka", "Nana",
    "Yuka", "Riko", "Mio", "Kanna", "Misaki", "Ayaka", "Saki", "Ayumi", "Hinata", "Miyuki",
    "Risa", "Miku", "Noa", "Riho", "Yoko", "Asuka", "Mana", "Kaede", "Risa", "Erika",
    "Mari", "Emi", "Mai", "Nanami", "Yumi", "Natsumi", "Arisa", "Kanon", "Yuriko", "Shiori",
    "Ayano", "Rie", "Nao", "Yuri", "Chika", "Maki", "Ai", "Nanako", "Rika", "Yuina",
    "Sora", "Kaho", "Maho", "Yuria", "Miho", "Sana", "Yui", "Megumi", "Ayaka", "Karin",
    "Mayu", "Haruna", "Eri", "Ami", "Akane", "Kana", "Minami", "Hikari", "Yui", "Yurika",
    "Miyako", "Kokoro", "Natsuki", "Misa", "Misa", "Kumi", "Kaori", "Yua", "Yuzuki", "Tomoka",
    "Satsuki", "Momo", "Shizuka", "Rin", "Mina", "Rin", "Ran", "Sayaka", "Hiroko", "Azusa",
    "Asami", "Honoka", "Fumiko", "Nagisa", "Yuko", "Kyoko", "Chisato", "Aya", "Mari", "Hiroe"
    };
    public static readonly string[] JapaneseSurnames = {
    "Sato", "Suzuki", "Takahashi", "Tanaka", "Watanabe", "Ito", "Yamamoto", "Nakamura", "Kobayashi", "Kato",
    "Yoshida", "Yamada", "Sasaki", "Yamaguchi", "Matsumoto", "Inoue", "Kimura", "Hayashi", "Shimizu", "Yamazaki",
    "Mori", "Abe", "Ikeda", "Hashimoto", "Yamashita", "Ishikawa", "Nakajima", "Maeda", "Fujita", "Ogawa",
    "Goto", "Okada", "Hasegawa", "Murakami", "Kondo", "Ishii", "Saito", "Sakamoto", "Endo", "Aoki",
    "Fujii", "Nishimura", "Fukuda", "Ota", "Miura", "Fujiwara", "Okamoto", "Matsuda", "Nakagawa", "Nakano",
    "Harada", "Ono", "Tamura", "Takeuchi", "Kaneko", "Wada", "Nakayama", "Ishida", "Ueda", "Morita",
    "Hara", "Shibata", "Sakai", "Matsui", "Shimada", "Yoshikawa", "Yokoyama", "Miyazaki", "Sugiyama", "Yagi",
    "Takagi", "Sato", "Suzuki", "Takahashi", "Tanaka", "Watanabe", "Ito", "Yamamoto", "Nakamura", "Kobayashi",
    "Kato", "Yoshida", "Yamada", "Sasaki", "Yamaguchi", "Matsumoto", "Inoue", "Kimura", "Hayashi", "Shimizu"
    };
    public static readonly string[] SpanishMaleNames = {
    "Javier", "Carlos", "Juan", "Luis", "Manuel", "Antonio", "Pedro", "Miguel", "Francisco", "José",
    "Daniel", "Alejandro", "Pablo", "Santiago", "David", "Fernando", "José Luis", "Rafael", "Andrés", "Mariano",
    "Diego", "Roberto", "Jorge", "Ángel", "José Manuel", "Raúl", "Rubén", "Emilio", "Tomás", "Juan Carlos",
    "Gonzalo", "Adrián", "Víctor", "Alberto", "Ignacio", "Francisco Javier", "Óscar", "Jaime", "Gabriel", "Eduardo",
    "José María", "Ricardo", "Federico", "Manolo", "Rafael", "César", "Sergio", "Héctor", "Jesús", "Albert",
    "Sergio", "Marcos", "Enrique", "Samuel", "Guillermo", "Josué", "Mario", "Pedro", "Álvaro", "Juanjo",
    "Esteban", "Julio", "Juan Antonio", "Agustín", "Miguel Ángel", "Cristian", "Iván", "Diego", "Lucas", "Eugenio",
    "Xavier", "Mauricio", "Lorenzo", "Juan Manuel", "José Antonio", "Mateo", "Raul", "Hugo", "Alex", "Félix",
    "Ramón", "José Ramón", "Nicolás", "Rogelio", "Patricio", "Paco", "Hernán", "Adolfo", "Fidel", "Salvador",
    "René", "Pascual", "Anselmo", "Juan José", "Bruno", "Cristóbal", "Alonso", "Eloy", "Julián", "Iker"
    };
    public static readonly string[] SpanishFemaleNames = {
    "María", "Laura", "Ana", "Isabel", "Carmen", "Luisa", "Elena", "Marta", "Sara", "Lucía",
    "Rosa", "Clara", "Adela", "Diana", "Patricia", "Sofía", "Natalia", "Beatriz", "Pilar", "Eva",
    "Lorena", "Lourdes", "Teresa", "Inés", "Rocío", "Ángela", "Alicia", "Carolina", "Paula", "Aurora",
    "Raquel", "Cristina", "Verónica", "Mercedes", "Gloria", "Silvia", "Marina", "Gisela", "Irene", "Susana",
    "Lidia", "Maribel", "Amparo", "Mónica", "Antonia", "Emma", "Bárbara", "Celia", "Victoria", "Olivia",
    "Esther", "Nerea", "África", "Miriam", "Elsa", "Gabriela", "Noelia", "Mireia", "Beatriz", "Daniela",
    "Ainhoa", "Vanesa", "Araceli", "Yolanda", "Paz", "Candela", "Nuria", "Miranda", "Montserrat", "Ruth",
    "Natalia", "Gemma", "Eugenia", "Aitana", "Clara", "Carla", "Ariadna", "Aitana", "Berta", "Luna",
    "Daniela", "Alba", "Alma", "Lola", "Helena", "Abril", "Aurora", "Carmen", "Iris", "Irma",
    "Juana", "Leonor", "Mara", "Marina", "Marta", "Maya", "Nora", "Olga", "Rosa", "Salma"
    };
    public static readonly string[] SpanishSurnames = {
    "García", "Hernández", "López", "Martínez", "González", "Rodríguez", "Pérez", "Sánchez", "Ramírez", "Flores",
    "Torres", "Rivera", "Gómez", "Díaz", "Reyes", "Morales", "Cruz", "Ortiz", "Ramos", "Romero",
    "Morales", "Vargas", "Castillo", "Guzmán", "Ortega", "Vázquez", "Mendoza", "Silva", "Herrera", "Medina",
    "León", "Jiménez", "Ponce", "Cortés", "Rangel", "Chávez", "Molina", "Delgado", "Campos", "Fuentes",
    "Mejía", "Vega", "Navarro", "Cabrera", "Acosta", "Miranda", "Orozco", "Guerrero", "Peña", "Lara",
    "Rojas", "Estrada", "Ríos", "Navarrete", "Contreras", "Luna", "Carrillo", "Álvarez", "Valencia", "Escobar",
    "Avila", "Santos", "Valenzuela", "Cervantes", "Salgado", "Valdés", "Espinoza", "Ibarra", "Zamora", "Pacheco",
    "Juárez", "Cruz", "Castañeda", "Andrade", "Aguilar", "Bautista", "Cortez", "Soria", "Terán", "Montes",
    "Corona", "Ontiveros", "Olivares", "Barrera", "Padilla", "Nava", "Trujillo", "Palacios", "Hurtado", "Beltrán"
    };
    public static readonly string[] PortugueseMaleNames = {
    "João", "Pedro", "Miguel", "Rafael", "Francisco", "Gustavo", "Diogo", "André", "Luís", "Bruno",
    "Tiago", "Tomás", "Carlos", "Guilherme", "Rui", "David", "Daniel", "António", "Manuel", "Hugo",
    "José", "Filipe", "Alexandre", "Fábio", "Ricardo", "Eduardo", "Leonardo", "Simão", "Gabriel", "Bernardo",
    "Luisinho", "Jorge", "Álvaro", "Henrique", "Sérgio", "Joaquim", "Vasco", "Nuno", "Samuel", "Fernando",
    "Mário", "Paulo", "Paulinho", "Vítor", "Renato", "Artur", "Marcos", "Gil", "Valentim", "Adriano",
    "Octávio", "Renato", "Raul", "Xavier", "Nicolau", "Alex", "Emanuel", "Marco", "Alberto", "Cristiano",
    "Elias", "Fernando", "Tomé", "Fernandinho", "Gregório", "Moisés", "Roberto", "Salvador", "Victor", "Eugénio",
    "Amadeu", "Joel", "Eduardinho", "Benjamim", "Ricardinho", "Diego", "Sandro", "Ricardão", "Marcelo", "Rogério",
    "Félix", "Simón", "Gilberto", "Afonso", "Ángel", "Tobias", "Clemente", "Agostinho", "Cândido", "Orlando",
    "Noé", "Eliseu", "Ernesto", "Elias", "Virgílio", "Luizinho", "Micael", "Renato", "Renatão", "Romeu"
    };
    public static readonly string[] PortugueseFemaleNames = {
    "Maria", "Ana", "Mariana", "Beatriz", "Sofia", "Carolina", "Ines", "Francisca", "Laura", "Marta",
    "Leonor", "Joana", "Matilde", "Rita", "Diana", "Andreia", "Filipa", "Clara", "Sara", "Catarina",
    "Helena", "Lara", "Luisa", "Teresa", "Isabel", "Adriana", "Raquel", "Daniela", "Cristina", "Patricia",
    "Gabriela", "Vanessa", "Mafalda", "Margarida", "Rafaela", "Alexandra", "Carla", "Paula", "Andreia", "Cecilia",
    "Gisela", "Rosa", "Marta", "Eduarda", "Sonia", "Tatiana", "Susana", "Vera", "Iris", "Carmen",
    "Elisabete", "Rute", "Carina", "Celia", "Lorena", "Lidia", "Micaela", "Alice", "Denise", "Fatima",
    "Goreti", "Heloisa", "Isabella", "Ivana", "Jéssica", "Laís", "Leticia", "Livia", "Luciana", "Magda",
    "Marcela", "Morgana", "Natália", "Nayara", "Nicole", "Olívia", "Patrícia", "Penélope", "Priscila", "Rebeca",
    "Regina", "Renata", "Sabrina", "Samara", "Sandra", "Silvana", "Simone", "Solange", "Tainá", "Talita",
    "Tamara", "Thais", "Vanessa", "Victoria", "Viviane", "Yasmin", "Zara", "Zélia", "Zilda", "Zoe"
    };
    public static readonly string[] PortugueseSurnames = {
    "Silva", "Santos", "Oliveira", "Souza", "Rodrigues", "Ferreira", "Alves", "Pereira", "Gomes", "Lima",
    "Costa", "Ribeiro", "Martins", "Rocha", "Almeida", "Melo", "Carvalho", "Barbosa", "Sousa", "Pinto",
    "Cardoso", "Nascimento", "Cunha", "Araújo", "Fernandes", "Cavalcanti", "Dias", "Castro", "Campos", "Monteiro",
    "Magalhães", "Vieira", "Freitas", "Batista", "Santana", "Lopes", "Sales", "Gonçalves", "Reis", "Lima",
    "Pacheco", "Mendes", "Moraes", "Peixoto", "Barros", "Nogueira", "Marques", "Xavier", "Bezerra", "Teixeira",
    "Cruz", "Moreira", "Caldeira", "Andrade", "Nunes", "Ramos", "Lira", "Borges", "Araujo", "Viana",
    "Farias", "Miranda", "Paiva", "Fonseca", "Aragão", "Correia", "Teles", "Morais", "Macedo", "Brito",
    "Pereira", "Cavalcante", "Moura", "Soares", "Vargas", "Aguiar", "Garcia", "Bastos", "Albuquerque", "Tavares",
    "Câmara", "Dantas", "Peixoto", "Gouveia", "Siqueira", "Vasconcelos", "Figueiredo", "Sampaio", "Amorim", "Alcântara"
    };
    public static readonly string[] ItalianMaleNames = {
    "Alessandro", "Andrea", "Antonio", "Davide", "Enrico", "Fabio", "Francesco", "Gabriele", "Giacomo", "Giorgio",
    "Giulio", "Giovanni", "Lorenzo", "Luca", "Marco", "Mario", "Mattia", "Matteo", "Michele", "Nicola",
    "Pietro", "Roberto", "Riccardo", "Salvatore", "Simone", "Stefano", "Tommaso", "Valerio", "Vincenzo", "Alberto",
    "Alfredo", "Angelo", "Bruno", "Carlo", "Cesare", "Claudio", "Daniele", "Diego", "Emanuele", "Emilio",
    "Federico", "Filippo", "Fulvio", "Giancarlo", "Gianluca", "Giuliano", "Guido", "Ivan", "Leonardo", "Luciano",
    "Ludovico", "Marcello", "Mauro", "Mirko", "Piero", "Raffaele", "Renato", "Riccardo", "Roberto", "Samuele",
    "Sandro", "Sebastiano", "Silvio", "Umberto", "Vittorio", "Agostino", "Aldo", "Alex", "Angelo", "Dario",
    "Elio", "Elvio", "Ernesto", "Eugenio", "Felice", "Gino", "Giovanni", "Giuseppe", "Guido", "Livio",
    "Mario", "Nello", "Nico", "Oscar", "Paolo", "Pietro", "Renzo", "Rocco", "Romano", "Tino",
    "Ugo", "Vito", "Walter", "Zeno", "Adriano", "Benedetto", "Emanuele", "Filippo", "Lucio", "Massimo"
    };
    public static readonly string[] ItalianFemaleNames = {
    "Alessia", "Alice", "Anna", "Aurora", "Beatrice", "Bianca", "Camilla", "Carolina", "Chiara", "Claudia",
    "Cristina", "Daniela", "Elena", "Elisa", "Emma", "Federica", "Francesca", "Gabriella", "Giada", "Giulia",
    "Laura", "Ludovica", "Marta", "Martina", "Matilde", "Michela", "Miriam", "Monica", "Nadia", "Nicole",
    "Noemi", "Patrizia", "Raffaella", "Rita", "Roberta", "Rossella", "Sara", "Serena", "Simona", "Silvia",
    "Sofia", "Stefania", "Valentina", "Valeria", "Vanessa", "Veronica", "Vittoria", "Adriana", "Agnese", "Agostina",
    "Alessandra", "Angelica", "Angela", "Antonella", "Assunta", "Barbara", "Caterina", "Cinzia", "Daria", "Debora",
    "Donatella", "Elda", "Elena", "Elettra", "Elisabetta", "Emanuela", "Fiorella", "Flavia", "Gemma", "Ginevra",
    "Giovanna", "Giulia", "Irene", "Isabella", "Letizia", "Liliana", "Linda", "Lisa", "Loredana", "Loretta",
    "Luisa", "Marcella", "Maria", "Marina", "Marta", "Miranda", "Monica", "Nadia", "Nicoletta", "Nunzia",
    "Ornella", "Paola", "Patrizia", "Piera", "Raffaella", "Rita", "Romina", "Sabrina", "Serena", "Silvana"
    };
    public static readonly string[] ItalianSurnames = {
    "Rossi", "Russo", "Ferrari", "Esposito", "Bianchi", "Romano", "Colombo", "Ricci", "Marino", "Greco",
    "Bruno", "Gallo", "Conti", "De Luca", "Mancini", "Costa", "Giordano", "Rizzo", "Lombardi", "Moretti",
    "Barbieri", "Fontana", "Santoro", "Mariani", "Rinaldi", "Caruso", "Ferrara", "Galli", "Martini", "Leone",
    "Longo", "Gentile", "Serra", "Marchetti", "Caputo", "Gatti", "Ferri", "Villa", "Riva", "Rizzi",
    "Lombardo", "Pagano", "Monti", "Parisi", "Bianco", "Vitale", "Carbone", "Fabbri", "Valentini", "Benedetti",
    "D'Angelo", "Farina", "Amato", "Grassi", "Pellegrini", "Palmieri", "Bernardi", "Mazza", "De Santis", "Cattaneo",
    "Negri", "Bellini", "Basile", "Piras", "Ferretti", "Fiore", "Riva", "Marini", "Costantini", "Santini",
    "Battaglia", "Ruggeri", "Poli", "Sanna", "De Rosa", "D'Amico", "Milani", "Coppola", "Fabbro", "Montanari",
    "De Angelis", "Lorenzini", "Piazza", "Donati", "Carli", "Maggio", "Damico", "Conte", "Coppola", "Santoro"
    };
    public static readonly string[] RussianMaleNames = {
    "Alexander", "Andrei", "Anatoli", "Anton", "Artem", "Boris", "Dmitri", "Egor", "Evgeni", "Fedor",
    "Georgi", "Gleb", "Grigori", "Igor", "Ivan", "Konstantin", "Leonid", "Maksim", "Mikhail", "Nikita",
    "Nikolai", "Oleg", "Pavel", "Roman", "Sergei", "Stanislav", "Stepan", "Valentin", "Viktor", "Vladimir",
    "Vladislav", "Yuri", "Aleksandr", "Aleksei", "Anatolij", "Antoni", "Artiom", "Borys", "Dymitr", "Fiodor",
    "Gieorgij", "Gleb", "Grzegorz", "Igor", "Iwan", "Konstanty", "Leonid", "Maksym", "Michail", "Nikita",
    "Nikolaj", "Oleksandr", "Oleksij", "Pawel", "Roma", "Siergiej", "Stanislaw", "Stiepan", "Walenty", "Wiktor",
    "Wladimir", "Wladyslaw", "Youri", "Alejandro", "Andres", "Angel", "Carlos", "Cesar", "Daniel", "Diego",
    "Eduardo", "Enrique", "Esteban", "Fernando", "Francisco", "Gabriel", "Gonzalo", "Guillermo", "Hugo", "Ivan",
    "Javier", "Jorge", "Jose", "Juan", "Julian", "Luis", "Manuel", "Marco", "Mario", "Miguel",
    "Pablo", "Pedro", "Raul", "Ricardo", "Roberto", "Rodrigo", "Salvador", "Samuel", "Sebastian"
    };
    public static readonly string[] RussianFemaleNames = {
    "Aleksandra", "Alena", "Anastasia", "Anna", "Daria", "Ekaterina", "Elena", "Evgenia", "Galina", "Inna",
    "Irina", "Julia", "Ksenia", "Larisa", "Liliya", "Lyudmila", "Maria", "Marina", "Nadezhda", "Natalia",
    "Nina", "Oksana", "Olga", "Svetlana", "Tatiana", "Valentina", "Valeria", "Vera", "Veronika", "Victoria",
    "Yelena", "Yulia", "Aleksandra", "Alena", "Anastasia", "Anna", "Daria", "Ekaterina", "Elena", "Evgeniya",
    "Galina", "Inna", "Irina", "Julia", "Kseniya", "Larisa", "Liliya", "Lyudmila", "Mariya", "Marina",
    "Nadezhda", "Nataliya", "Nina", "Oksana", "Olga", "Svetlana", "Tatiana", "Valentina", "Valeriya", "Vera",
    "Veronika", "Viktoriya", "Yelena", "Yuliya", "Alejandra", "Ana", "Andrea", "Carla", "Carmen", "Claudia",
    "Daniela", "Elena", "Estefania", "Fernanda", "Gabriela", "Isabel", "Laura", "Lorena", "Lucia", "Marcela",
    "Maria", "Marta", "Monica", "Natalia", "Patricia", "Paula", "Rosa", "Sandra", "Sara", "Silvia"
    };
    public static readonly string[] RussianSurnames = {
    "Ivanov", "Smirnov", "Kuznetsov", "Popov", "Sokolov", "Lebedev", "Kozlov", "Novikov", "Morozov", "Petrov",
    "Volkov", "Soloviev", "Vasilyev", "Zaitsev", "Pavlov", "Semyonov", "Golubev", "Vinogradov", "Bogdanov", "Vorobyov",
    "Fedorov", "Mikhailov", "Belyaev", "Tarasov", "Belov", "Komarov", "Orehov", "Kiselev", "Mironov", "Kovalev",
    "Sorokin", "Andreev", "Safonov", "Titov", "Dmitriev", "Kuzmin", "Alexeev", "Gusev", "Kiselyov", "Kudryavtsev",
    "Savin", "Nikolaev", "Sokolnikov", "Polyakov", "Ilyin", "Blinov", "Tikhonov", "Kazakov", "Artemiev", "Nikitin",
    "Zakharov", "Abramov", "Antonov", "Egorov", "Nikitin", "Krylov", "Pankratov", "Lykov", "Plotnikov", "Ovchinnikov",
    "Zubkov", "Kabanov", "Andreev", "Frolov", "Gorbachev", "Zakharov", "Belyakov", "Vasilev", "Savin", "Melnikov",
    "Maslov", "Vlasov", "Mishin", "Kolobov", "Kirillov", "Nikonov", "Sergiyev", "Polyakov", "Sobolev", "Rusakov",
    "Fomin", "Ryabov", "Prokhorov", "Kulikov", "Alekseyev", "Semenov", "Markov", "Shirokov", "Filatov", "Molchanov"
    };
    public static readonly string[] PolishMaleNames = {
    "Adam", "Adrian", "Albert", "Aleksander", "Andrzej", "Antoni", "Arkadiusz", "Artur", "Bartlomiej", "Bogdan",
    "Dariusz", "Daniel", "Dawid", "Dominik", "Edward", "Filip", "Grzegorz", "Hubert", "Jacek", "Jakub",
    "Jan", "Jaroslaw", "Jozef", "Kamil", "Krzysztof", "Leszek", "Lukasz", "Marcin", "Marek", "Mariusz",
    "Mateusz", "Michal", "Mikolaj", "Pawel", "Piotr", "Rafal", "Robert", "Ryszard", "Sebastian", "Slawomir",
    "Stanislaw", "Tomasz", "Waldemar", "Wieslaw", "Wojciech", "Zbigniew", "Adam", "Adrian", "Albert", "Aleksander",
    "Andrzej", "Antoni", "Arkadiusz", "Artur", "Bartlomiej", "Bogdan", "Dariusz", "Daniel", "Dawid", "Dominik",
    "Edward", "Filip", "Grzegorz", "Hubert", "Jacek", "Jakub", "Jan", "Jaroslaw", "Jozef", "Kamil",
    "Krzysztof", "Leszek", "Lukasz", "Marcin", "Marek", "Mariusz", "Mateusz", "Michal", "Mikolaj", "Pawel",
    "Piotr", "Rafal", "Robert", "Ryszard", "Sebastian", "Slawomir", "Stanislaw", "Tomasz", "Waldemar", "Wieslaw",
    "Wojciech", "Zbigniew", "Alejandro", "Andres", "Antonio", "Carlos", "Cesar", "David", "Diego", "Eduardo",
    "Emilio", "Fernando", "Francisco", "Gabriel", "Gonzalo", "Guillermo", "Hugo", "Ignacio", "Jaime", "Javier"
    };
    public static readonly string[] PolishFemaleNames = {
    "Agnieszka", "Aleksandra", "Alicja", "Aneta", "Angelika", "Anna", "Beata", "Dorota", "Eliza", "Ewa",
    "Gabriela", "Hanna", "Irena", "Iwona", "Joanna", "Julia", "Justyna", "Kamila", "Karolina", "Katarzyna",
    "Kinga", "Klaudia", "Magdalena", "Maria", "Martyna", "Monika", "Natalia", "Patrycja", "Paulina",
    "Renata", "Sylwia", "Teresa", "Urszula", "Weronika", "Zofia", "Agnieszka", "Aleksandra", "Alicja", "Aneta",
    "Angelika", "Anna", "Beata", "Dorota", "Eliza", "Ewa", "Gabriela", "Hanna", "Irena", "Iwona",
    "Joanna", "Julia", "Justyna", "Kamila", "Karolina", "Katarzyna", "Kinga", "Klaudia", "Magdalena",
    "Maria", "Martyna", "Monika", "Natalia", "Patrycja", "Paulina", "Renata", "Sylwia", "Teresa", "Urszula",
    "Weronika", "Zofia", "Alejandra", "Ana", "Andrea", "Carla", "Carmen", "Claudia", "Daniela", "Elena",
    "Emilia", "Fernanda", "Gabriela", "Isabel", "Laura", "Lorena", "Lucia", "Marcela", "Maria", "Marta"
    };
    public static readonly string[] PolishSurnames = {
    "Nowak", "Kowalski", "Wisniewski", "Wojcik", "Kowalczyk", "Kaminski", "Lewandowski", "Zielinski", "Szymanski", "Wozniak",
    "Dabrowski", "Kozlowski", "Jankowski", "Mazur", "Kwiatkowski", "Wojciechowski", "Krawczyk", "Kaczmarek", "Piotrowski", "Grabowski",
    "Zajac", "Krol", "Pawlowski", "Michalski", "Wrobel", "Jablonski", "Wieczorek", "Nowakowski", "Majewski", "Olszewski",
    "Stepien", "Malinowski", "Jaworski", "Adamczyk", "Witkowski", "Walczak", "Sikora", "Baran", "Gorecki", "Rutkowski",
    "Michalak", "Szewczyk", "Ostrowski", "Tomaszewski", "Pawlak", "Duda", "Zalewski", "Jakubowski", "Glowacki", "Lis",
    "Wojtowicz", "Kubiak", "Kolodziej", "Kazmierczak", "Czarnecki", "Sobczak", "Konieczny", "Urbanski", "Gajewski", "Krajewski",
    "Czerwinski", "Mroz", "Klimek", "Marciniak", "Grzelak", "Laskowski", "Zawadzki", "Szulc", "Sadowski", "Makowski",
    "Gorski", "Brzezinski", "Baranowski", "Pietrzak", "Matuszewski", "Wilk", "Blaszczyk", "Chmielewski", "Cieslak", "Szczepanski",
    "Kaczmarczyk", "Leszczynski", "Janik", "Borkowski", "Szczepaniak", "Kazmierczak", "Ciesielski", "Rozycki", "Debski", "Majchrzak"
    };
    public static readonly string[] RomanianMaleNames = {
    "Alexandru", "Andrei", "Cristian", "Daniel", "Dorin", "Florin", "Gabriel", "George", "Ion", "Marius", "Nicolae",
    "Radu", "Sorin", "Stefan", "Valentin", "Vasile", "Adrian", "Alin", "Aurel","Bogdan", "Catalin", "Claudiu",
    "Constantin", "Cosmin", "Cristinel", "Dorinel", "Eduard", "Emil", "Eugen", "Flaviu", "Gheorghe", "Ilie",
    "Ioan", "Iulian", "Laurentiu", "Liviu", "Lucian", "Marcel", "Marian", "Mihai", "Mircea", "Octavian",
    "Paul", "Petru", "Razvan", "Robert", "Sebastian", "Stefan", "Tiberiu", "Victor", "Viorel"
    };
    public static readonly string[] RomanianFemaleNames = {
    "Alexandra",
    "Andreea",
    "Cristina",
    "Daniela",
    "Doina",
    "Florentina",
    "Gabriela",
    "Georgiana",
    "Ileana",
    "Maria",
    "Nicoleta",
    "Raluca",
    "Simona",
    "Stefania",
    "Valentina",
    "Viorica",
    "Adriana",
    "Alina",
    "Aurora",
    "Beatrice",
    "Carmen",
    "Catalina",
    "Cecilia",
    "Cristiana",
    "Diana",
    "Elena",
    "Eugenia",
    "Florina",
    "Gabriela",
    "Georgeta",
    "Ioana",
    "Laura",
    "Liliana",
    "Lucia",
    "Magdalena",
    "Mihaela",
    "Monica",
    "Nadia",
    "Oana",
    "Paula",
    "Petronela",
    "Roxana",
    "Sabina",
    "Silvia",
    "Teodora",
    "Valeria",
    "Violeta",
    "Virginia"
    };
    public static readonly string[] RomanianSurnames = {
    "Popescu", "Ionescu", "Popa", "Pop", "Dumitru", "Dima", "Stan", "Stoica", "Mihai", "Radu",
    "Pavel", "Georgescu", "Constantin", "Munteanu", "Andrei", "Tudor", "Gheorghe", "Nistor", "Vasile", "Cristea",
    "Marin", "Florea", "Barbu", "Balan", "Lazar", "Preda", "Petrescu", "Diaconu", "Sandu", "Vlad",
    "Dobre", "Costea", "Moldovan", "Serban", "Gavrila", "Neagu", "Cretu", "Iordache", "Dinu", "Tanase",
    "Sava", "Alexandru", "Dinca", "Toma", "Albu", "Avram", "Ivan", "Cojocaru", "Nedelcu", "Ciobanu",
    "Badea", "Pascu", "Rosu", "Dumitrache", "Filip", "Grigore", "Paun", "Baciu", "Sorin", "Stefan",
    "Nicolae", "Bucur", "Fratila", "Pavel", "Crisan", "Roman", "Anton", "Prodan", "Luca", "Tanasa",
    "Coman", "Nicolae", "Nitu", "Dima", "Dragomir", "Vasilescu", "Iacob", "Barbu", "Birlea", "Grosu",
    "Petre", "Turcu", "Hristea", "Iordache", "Preda", "Dascalu", "Vasile", "Mocanu", "Dumitrescu", "Trif",
    "Pana", "Mocanu", "Petre", "Dan", "Oprea", "Rosca", "Chirita", "Iacob", "Teodorescu", "Muresan"
    };
    public static readonly string[] IndianMaleNames = {
    "Aarav",
    "Abhinav",
    "Aditya",
    "Akash",
    "Amit",
    "Aniket",
    "Arjun",
    "Ashish",
    "Deepak",
    "Gaurav",
    "Hari",
    "Jagdish",
    "Karan",
    "Manish",
    "Mukesh",
    "Naveen",
    "Nikhil",
    "Prakash",
    "Rahul",
    "Rajesh",
    "Rakesh",
    "Ramesh",
    "Ravi",
    "Sanjay",
    "Satish",
    "Shankar",
    "Sunil",
    "Suresh",
    "Tarun",
    "Vikram",
    "Vishal",
    "Yash",
    "Ajay",
    "Amitabh",
    "Anand",
    "Ashok",
    "Chetan",
    "Dilip",
    "Ganesh",
    "Jatin",
    "Kamal",
    "Mahesh",
    "Mohan",
    "Nitin",
    "Pankaj",
    "Pradeep",
    "Rajendra",
    "Sachin",
    "Sanjeev",
    "Sudhir",
    "Vijay"
    };
    public static readonly string[] IndianFemaleNames = {
    "Aaradhya",
    "Aditi",
    "Aishwarya",
    "Ananya",
    "Anika",
    "Anita",
    "Archana",
    "Deepika",
    "Divya",
    "Gita",
    "Indira",
    "Jaya",
    "Kajal",
    "Kavita",
    "Lakshmi",
    "Madhavi",
    "Meera",
    "Neha",
    "Nisha",
    "Pooja",
    "Priya",
    "Rachana",
    "Rani",
    "Rekha",
    "Rina",
    "Riya",
    "Sapna",
    "Sarika",
    "Shilpa",
    "Shruti",
    "Simran",
    "Smita",
    "Sneha",
    "Sunita",
    "Swati",
    "Tanvi",
    "Trisha",
    "Uma",
    "Usha",
    "Vandana",
    "Varsha",
    "Vidya",
    "Vijaya",
    "Yamini",
    "Zara",
    "Aditi",
    "Ambika",
    "Anjali",
    "Asha",
    "Ashwini"
    };
    public static readonly string[] IndianSurnames = {
    "Patel", "Sharma", "Kumar", "Mehta", "Singh", "Gupta", "Shah", "Verma", "Joshi", "Malhotra",
    "Chawla", "Soni", "Choudhury", "Mittal", "Shinde", "Rao", "Desai", "Kaur", "Reddy", "Thakur",
    "Pandey", "Bhattacharya", "Yadav", "Das", "Ali", "Saxena", "Banerjee", "Chatterjee", "Dutta", "Bose",
    "Mahajan", "Nair", "Prasad", "Iyer", "Ahmed", "Kulkarni", "Pillai", "Menon", "Chakraborty", "Rajput",
    "Sinha", "Srivastava", "Rastogi", "Chopra", "Jacob", "Sethi", "Thomas", "Deshmukh", "Dutta", "Agarwal",
    "Mohammed", "Khan", "Biswas", "Goswami", "Mishra", "Sengupta", "Bhatt", "Rana", "Parekh", "Malik",
    "Majumdar", "Singhania", "Gandhi", "Mukherjee", "Bajaj", "Garg", "Sarin", "Tiwari", "Shukla", "Rawat",
    "Kamble", "Shroff", "Narayan", "Sharma", "Chauhan", "Choudhary", "Rathore", "Kapoor", "Yadav", "Trivedi",
    "Raj", "Dewan", "Jain", "Chawla", "Seth", "Ranganathan", "Purohit", "Ahuja", "Prakash", "Sarin",
    "Sethi", "Sundaram", "Lal", "Monga", "Khanna", "Varma", "Nanda", "Dalal", "Sarin", "Anand"
    };

    public static string GetRandomNameSurname(string motherland = "", bool isMale = true) {
        switch (motherland) {
            case "USA":
                if (isMale) {
                    return AmericanMaleNames[Random.Range(0, AmericanMaleNames.Length)] + " " + AmericanSurnames[Random.Range(0, AmericanSurnames.Length)];
                }
                else {
                    return AmericanFemaleNames[Random.Range(0, AmericanFemaleNames.Length)] + " " + AmericanSurnames[Random.Range(0, AmericanSurnames.Length)];
                }
            case "England":
                if (isMale) {
                    return BritishMaleNames[Random.Range(0, BritishMaleNames.Length)] + " " + BritishSurnames[Random.Range(0, BritishSurnames.Length)];
                }
                else {
                    return BritishFemaleNames[Random.Range(0, BritishFemaleNames.Length)] + " " + BritishSurnames[Random.Range(0, BritishSurnames.Length)];
                }
            case "Germany":
                if (isMale) {
                    return GermanMaleNames[Random.Range(0, GermanMaleNames.Length)] + " " + GermanSurnames[Random.Range(0, GermanSurnames.Length)];
                }
                else {
                    return GermanFemaleNames[Random.Range(0, GermanFemaleNames.Length)] + " " + GermanSurnames[Random.Range(0, GermanSurnames.Length)];
                }
            case "France":
                if (isMale) {
                    return FrenchMaleNames[Random.Range(0, FrenchMaleNames.Length)] + " " + FrenchSurnames[Random.Range(0, FrenchSurnames.Length)];
                }
                else {
                    return FrenchFemaleNames[Random.Range(0, FrenchFemaleNames.Length)] + " " + FrenchSurnames[Random.Range(0, FrenchSurnames.Length)];
                }
            case "Turkey":
                if (isMale) {
                    return TurkishMaleNames[Random.Range(0, TurkishMaleNames.Length)] + " " + TurkishSurnames[Random.Range(0, TurkishSurnames.Length)];
                }
                else {
                    return TurkishFemaleNames[Random.Range(0, TurkishFemaleNames.Length)] + " " + TurkishSurnames[Random.Range(0, TurkishSurnames.Length)];
                }
            case "China":
                if (isMale) {
                    return ChineseMaleNames[Random.Range(0, ChineseMaleNames.Length)] + " " + ChineseSurnames[Random.Range(0, ChineseSurnames.Length)];
                }
                else {
                    return ChineseFemaleNames[Random.Range(0, ChineseFemaleNames.Length)] + " " + ChineseSurnames[Random.Range(0, ChineseSurnames.Length)];
                }
            case "Japan":
                if (isMale) {
                    return JapaneseMaleNames[Random.Range(0, JapaneseMaleNames.Length)] + " " + JapaneseSurnames[Random.Range(0, JapaneseSurnames.Length)];
                }
                else {
                    return JapaneseFemaleNames[Random.Range(0, JapaneseFemaleNames.Length)] + " " + JapaneseSurnames[Random.Range(0, JapaneseSurnames.Length)];
                }
            case "Mexico":
                if (isMale) {
                    return SpanishMaleNames[Random.Range(0, SpanishMaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
                else {
                    return SpanishFemaleNames[Random.Range(0, SpanishFemaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
            case "Brazil":
                if (isMale) {
                    return PortugueseMaleNames[Random.Range(0, PortugueseMaleNames.Length)] + " " + PortugueseSurnames[Random.Range(0, PortugueseSurnames.Length)];
                }
                else {
                    return PortugueseFemaleNames[Random.Range(0, PortugueseFemaleNames.Length)] + " " + PortugueseSurnames[Random.Range(0, PortugueseSurnames.Length)];
                }
            case "Argentina":
                if (isMale) {
                    return SpanishMaleNames[Random.Range(0, SpanishMaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
                else {
                    return SpanishFemaleNames[Random.Range(0, SpanishFemaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
            case "Spain":
                if (isMale) {
                    return SpanishMaleNames[Random.Range(0, SpanishMaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
                else {
                    return SpanishFemaleNames[Random.Range(0, SpanishFemaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
            case "Italy":
                if (isMale) {
                    return ItalianMaleNames[Random.Range(0, ItalianMaleNames.Length)] + " " + ItalianSurnames[Random.Range(0, ItalianSurnames.Length)];
                }
                else {
                    return ItalianFemaleNames[Random.Range(0, ItalianFemaleNames.Length)] + " " + ItalianSurnames[Random.Range(0, ItalianSurnames.Length)];
                }
            case "Russia":
                if (isMale) {
                    return RussianMaleNames[Random.Range(0, RussianMaleNames.Length)] + " " + RussianSurnames[Random.Range(0, RussianSurnames.Length)];
                }
                else {
                    return RussianFemaleNames[Random.Range(0, RussianFemaleNames.Length)] + " " + RussianSurnames[Random.Range(0, RussianSurnames.Length)];
                }
            case "Poland":
                if (isMale) {
                    return PolishMaleNames[Random.Range(0, PolishMaleNames.Length)] + " " + PolishSurnames[Random.Range(0, PolishSurnames.Length)];
                }
                else {
                    return PolishFemaleNames[Random.Range(0, PolishFemaleNames.Length)] + " " + PolishSurnames[Random.Range(0, PolishSurnames.Length)];
                }
            case "Romania":
                if (isMale) {
                    return RomanianMaleNames[Random.Range(0, RomanianMaleNames.Length)] + " " + RomanianSurnames[Random.Range(0, RomanianSurnames.Length)];
                }
                else {
                    return RomanianFemaleNames[Random.Range(0, RomanianFemaleNames.Length)] + " " + RomanianSurnames[Random.Range(0, RomanianSurnames.Length)];
                }
            case "India":
                if (isMale) {
                    return IndianMaleNames[Random.Range(0, IndianMaleNames.Length)] + " " + IndianSurnames[Random.Range(0, IndianSurnames.Length)];
                }
                else {
                    return IndianFemaleNames[Random.Range(0, IndianFemaleNames.Length)] + " " + IndianSurnames[Random.Range(0, IndianSurnames.Length)];
                }
            case "Columbia":
                if (isMale) {
                    return SpanishMaleNames[Random.Range(0, SpanishMaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
                else {
                    return SpanishFemaleNames[Random.Range(0, SpanishFemaleNames.Length)] + " " + SpanishSurnames[Random.Range(0, SpanishSurnames.Length)];
                }
            default:
                return GetRandomNameSurname("USA", isMale);
        }
    }
}
public static class PlayerMoneyCapacities
{
    public const ulong MAX_MONEY = 99999999999;
}
#endregion

#region Characters
public class BaseCharacter
{
    #region Declerations
    public string Name { get; set; }
    public bool IsMale { get; set; } //Non-Binary is null
    public byte Age { get; set; } //Age
    public bool AgeBuffs { get; set; } //Age Buff Key
    public ushort Level { get; set; } //Cap 30.000
    public uint LevelXP { get; set; } //Cap 1.000.000 each level
    public ushort Renown { get; set; } //Cap 1000
    public ushort Dependability { get; set; } //Cap 1000
    public byte WantedLevel { get; set; } //Cap 10
    public Country Motherland { get; set; }
    public City CurrentLocation { get; set; }
    public List<Trial> Trials { get; set; }
    public List<Player> KnownPlayers { get; set; }
    public List<Player> FriendPlayers { get; set; }
    public List<Player> EnemyPlayers { get; set; }
    public List <NPC> KnownNPCs { get; set; }
    public List<NPC> FriendNPCs { get; set; }
    public List<NPC> EnemyNPCs { get; set; }
    public bool InParole { get; set; }
    public GameDate ParoleEndDate { get; set; }
    public bool InPrison { get; set; }
    public GameDate PrisonEndDate { get; set; }
    public bool IsDeathSentenced { get; set; }
    public GameDate ExecutionDate { get; set; }
    public bool IsDead { get; set; }
    public bool IsOnARun { get; set; }
    //Skills
    public byte BusinessLevel { get; set; }
    public byte BusinessLevelXP { get; set; }
    public byte CharmLevel { get; set; }
    public byte CharmLevelXP { get; set; }
    public byte IntelligenceLevel { get; set; }
    public byte IntelligenceLevelXP { get; set; }
    public byte PowerLevel { get; set; }
    public byte PowerLevelXP { get; set; }
    public byte StealthLevel { get; set; }
    public byte StealthLevelXP { get; set; }
    public byte HandinessLevel { get; set; }
    public byte HandinessLevelXP { get; set; }
    public byte TechLevel { get; set; }
    public byte TechLevelXP { get; set; }
    public bool LikesLoudStyle { get; set; }
    public bool IsScientist { get; set; }
    public byte LabLevel { get; set; }
    public byte LabLevelXP { get; set; }
    public byte FarmerLevel { get; set; }
    public byte FarmerLevelXP { get; set; }
    public byte ProduceMethLevel { get; set; }
    public byte ProduceMethLevelXP { get; set; }
    public byte ProduceCocainLevel { get; set; }
    public byte ProduceCocainLevelXP { get; set; }
    public byte ProduceWeedLevel { get; set; }
    public byte ProduceWeedLevelXP { get; set; }
    public byte ProduceMDMALevel { get; set; }
    public byte ProduceMDMALevelXP { get; set; }
    public byte ConnectionsLevel { get; set; }
    public byte ConnectionsLevelXP { get; set; }
    public byte TransporterLevel { get; set; }
    public byte TransporterLevelXP { get; set; }
    //Accountant
    public byte MoneyLaunderingLevel { get; set; }
    public byte MoneyLaunderingLevelXP { get; set; }
    public bool IsAccountant { get; set; }
    //Lawyer
    public byte LawyeringLevel { get; set; }
    public byte LawyeringLevelXP { get; set; }
    public bool BarPass { get; set; }
    //Operate
    public byte OperatingLevel { get; set; }
    public byte OperatingLevelXP { get; set; }

    //References for notification system.
    protected Player RefPlayer { get; set; }
    protected NPC RefNPC { get; set; }
    #endregion

    #region Constructor Method
    public BaseCharacter()
    {
        Name = "";
        IsMale = true;
        Age = 18;
        AgeBuffs = true;
        Level = 0;
        LevelXP = 0;
        Renown = 0;
        Dependability = 0;
        WantedLevel = 0;
        Motherland = LocationStorage.Turkey;
        CurrentLocation = LocationStorage.Istanbul;
        Trials = new List<Trial>();
        KnownPlayers = new List<Player>();
        FriendPlayers = new List<Player>();
        EnemyPlayers = new List<Player>();
        KnownNPCs = new List<NPC>();
        FriendNPCs = new List<NPC>();
        EnemyNPCs = new List<NPC>();
        InParole = false;
        ParoleEndDate = new GameDate();
        InPrison = false;
        PrisonEndDate = new GameDate();
        IsDeathSentenced = false;
        ExecutionDate = new GameDate();
        IsOnARun = false;
        IsDead = false;
        //
        BusinessLevel = 0;
        BusinessLevelXP = 0;
        CharmLevel = 0;
        CharmLevelXP = 0;
        IntelligenceLevel = 0;
        IntelligenceLevelXP = 0;
        PowerLevel = 0;
        PowerLevelXP = 0;
        StealthLevel = 0;
        StealthLevelXP = 0;
        HandinessLevel = 0;
        HandinessLevelXP = 0;
        TechLevel = 0;
        TechLevelXP = 0;
        LikesLoudStyle = true;
        IsScientist = false;
        LabLevel = 0;
        LabLevelXP = 0;
        FarmerLevel = 0;
        FarmerLevelXP = 0;
        ProduceMethLevel = 0;
        ProduceMethLevelXP = 0;
        ProduceCocainLevel = 0;
        ProduceCocainLevelXP = 0;
        ProduceWeedLevel = 0;
        ProduceWeedLevelXP = 0;
        ProduceMDMALevel = 0;
        ProduceMDMALevelXP = 0;
        ConnectionsLevel = 0;
        ConnectionsLevelXP = 0;
        TransporterLevel = 0;
        TransporterLevelXP = 0;
        MoneyLaunderingLevel = 0;
        MoneyLaunderingLevelXP = 0;
        IsAccountant = false;
        LawyeringLevel = 0;
        LawyeringLevelXP = 0;
        BarPass = false;
        OperatingLevel = 0;
        OperatingLevelXP = 0;

        //References
        RefPlayer = null;
        RefNPC = null;
    }
    #endregion

    #region Methods
    //Triggers
    public void TriggerDaily()
    {
        //Getting caught & imprisonment
        if (!InPrison)
        {
            PrisonEndDate.AddDay(1);

            if (WantedLevel > 2)
            {
                if (CurrentLocation.IsHighlyPopulated)
                {
                    if (WantedLevel * CharacterEventValues.CHANCE_TO_GET_CAUGHT_PER_WANTED_LEVEL <= Random.Range(0, 101))
                    {
                        SetPrisonState(true);

                        if (IsDeathSentenced)
                        {
                            GameDate executionDate = GameController.gameDate;
                            executionDate.AddMonth(1);
                            SetExecutionDate(executionDate);
                        }
                    }
                    else
                    {
                        GiveLevelXP(CharacterCapacities.LEVEL_XP_CAP * WantedLevel + 10);
                    }
                }
                else
                {
                    if (WantedLevel / 4 <= Random.Range(0, 101))
                    {
                        SetPrisonState(true);
                        if (IsDeathSentenced)
                        {
                            GameDate executionDate = GameController.gameDate;
                            executionDate.AddMonth(1);
                            SetExecutionDate(executionDate);
                        }
                    }
                    else
                    {
                        GiveLevelXP((CharacterCapacities.LEVEL_XP_CAP / 5) * WantedLevel);
                    }
                }
            }
        }

        //Trials
        if (InPrison)
        {
            foreach (Trial trial in Trials)
            {
                if (!trial.IsArchived)
                {
                    if (trial.ExecuteDate == GameController.gameDate)
                    {
                        trial.ExecuteTrial();
                    }
                }
            }
        }

        //Prison End
        if (PrisonEndDate == GameController.gameDate && InPrison && !IsDeathSentenced)
        {
            SetPrisonState(false);
        }

        //Death penalty execution
        if (IsDeathSentenced && ExecutionDate == GameController.gameDate && InPrison)
        {
            Kill("Execution.");
        }
    }
    public void TriggerWeekly()
    {

    }
    public void TriggerMonthly()
    {

    }
    public void TriggerYearly()
    {

    }
    //Age
    public void AgeUp()
    {
        //Characters can die cause of old age
        Age++;

        if (Age > CharacterAgeRules.NATURAL_DEATH_START_AGE)
        {
            byte chanceToDie = Convert.ToByte((Age - CharacterAgeRules.NATURAL_DEATH_START_AGE) * CharacterAgeRules.NATURAL_DEATH_PERCENT_DRIFT);
            if (Random.Range(0, 101) <= chanceToDie)
            {
                Kill("Old age.");
            }
        }

        //INCOMPLETE
        if (AgeBuffs)
        {
            if (Age > 50) //Renown increase
            {
                Renown = Convert.ToUShort(Renown + (Renown / 30));
            }
            if (Age > 60) //Dep decrease
            {
                Dependability = Convert.ToUShort(Dependability - (Dependability / 15));
            }
            if (Age > 35 && Age < 85) //Business increase
            {
                AddBusinessLevelXP(Convert.ToByte(BusinessLevel / 10));
            }
            else if (Age > 85) //Business decrease
            {
                BusinessLevel -= 1;
            }
            if (Age > 40 && Age < 80) //Charm increase
            {
                AddCharmLevelXP(Convert.ToByte(CharmLevel / 10));
            }
            else if (Age > 80) //Charm decrease
            {
                CharmLevel -= 1;
            }
            if (Age > 20 && Age < 65) //Intelligence increase
            {
                AddIntelligenceLevelXP(Convert.ToByte(IntelligenceLevel / 25));
            }
            else if (Age > 65) //Intelligence decrease
            {
                IntelligenceLevel -= 5;
            }
            if (Age > 18 && Age < 45) //Power increase
            {
                AddPowerLevelXP(Convert.ToByte(PowerLevel / 10));
            }
            else if (Age > 45) //Power decrease
            {
                PowerLevel -= 5;
            }
        }
    }
    //Level XP methods
    public void GiveLevelXP(uint GainedXP = 0) {
        if (Level >= CharacterCapacities.LEVEL_CAP) {
            Level = CharacterCapacities.LEVEL_CAP;
            LevelXP = CharacterCapacities.LEVEL_XP_CAP;
        }
        else {
            if (GainedXP + LevelXP >= CharacterCapacities.LEVEL_XP_CAP) {
                uint OverageXP = (GainedXP + LevelXP) - CharacterCapacities.LEVEL_XP_CAP;
                Level++;
                if (OverageXP >= CharacterCapacities.LEVEL_XP_CAP) {
                    GiveLevelXP(OverageXP);
                }
                else {
                    LevelXP = OverageXP;
                }
            }
            else {
                LevelXP += GainedXP;
            }
        }
    }
    //Renown methods
    public void GiveRenown(ushort GainedRenown)
    {
        if (GainedRenown + Renown >= CharacterCapacities.RENOWN_CAP)
        {
            Renown = CharacterCapacities.RENOWN_CAP;
        }
        else
        {
            Renown += GainedRenown;
            GameMessageScript.Notification("+" + GainedRenown + " Renown.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void TakeRenown(ushort LostRenown)
    {
        if (Renown - LostRenown <= 0)
        {
            Renown = 0;
        }
        else
        {
            Renown -= LostRenown;
            GameMessageScript.Notification("-" + LostRenown + " Renown.", new List<Player> { RefPlayer }, Color.red, true);
        }
    }
    //Dependability methods
    public void GiveDependability(ushort GainedDependability)
    {
        if (GainedDependability + Dependability >= CharacterCapacities.DEPENDABILITY_CAP)
        {
            Dependability = CharacterCapacities.DEPENDABILITY_CAP;
        }
        else
        {
            Dependability += GainedDependability;
            GameMessageScript.Notification("+" + GainedDependability + " Dependability.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void TakeDependability(ushort LostDependability)
    {
        if (Dependability - LostDependability <= 0)
        {
            Dependability = 0;
        }
        else
        {
            Dependability -= LostDependability;
            GameMessageScript.Notification("-" + LostDependability + " Dependability.", new List<Player> { RefPlayer }, Color.red, true);
        }
    }
    //Wanted Level methods
    public void GiveWantedLevel(byte GainedWantedLevel)
    {
        if (GainedWantedLevel + WantedLevel >= CharacterCapacities.WANTED_LEVEL_CAP)
        {
            WantedLevel = CharacterCapacities.WANTED_LEVEL_CAP;
        }
        else
        {
            WantedLevel += GainedWantedLevel;
            GameMessageScript.Notification("+" + GainedWantedLevel + " Wanted Level.", new List<Player> { RefPlayer }, Color.red, true);
        }
    }
    public void TakeWantedLevel(byte LostWantedLevel)
    {
        if (WantedLevel - LostWantedLevel <= 0)
        {
            WantedLevel = 0;
        }
        else
        {
            WantedLevel -= LostWantedLevel;
            GameMessageScript.Notification("-" + LostWantedLevel + " Wanted Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    //Location methods
    public void ChangeCurrentLocation(City newCurrentLocation)
    {
        CurrentLocation = newCurrentLocation;
    }
    //Trial methods (No notifications due to already taken notification inside "Crimes.cs")
    public void AddTrial(Trial newTrial)
    {
        Trials.Add(newTrial);
    }
    public void RemoveTrial(Trial trial)
    {
        if (Trials.Contains(trial))
        {
            Trials.Remove(trial);
        }
    }
    //Met, Friend and Enemy with input character
    public void MetThisPlayer(Player player)
    {
        KnownPlayers.Add(player);

        GameMessageScript.Notification(player.Name + " is added to your contact list.", new List<Player> { RefPlayer }, Color.blue, true);
    }
    public void FriendThisPlayer(Player player)
    {
        if (KnownPlayers.Contains(player))
        {
            FriendPlayers.Add(player);

            GameMessageScript.Notification(player.Name + " is your close friend now.", new List<Player> { RefPlayer }, Color.blue, true);
        }
    }
    public void EnemyThisPlayer(Player player)
    {
        if (KnownPlayers.Contains(player))
        {
            EnemyPlayers.Add(player);

            GameMessageScript.Notification(player.Name + " is your enemy now.", new List<Player> { RefPlayer }, Color.yellow, true);
        }
    }
    public void MetThisNPC(NPC npc)
    {
        KnownNPCs.Add(npc);

        GameMessageScript.Notification(npc.Name + " is added to your contact list.", new List<Player> { RefPlayer }, Color.blue, true);
    }
    public void FriendThisNPC(NPC npc)
    {
        if (KnownNPCs.Contains(npc))
        {
            FriendNPCs.Add(npc);

            GameMessageScript.Notification(npc.Name + " is your close friend now.", new List<Player> { RefPlayer }, Color.blue, true);
        }
    }
    public void EnemyThisNPC(NPC npc)
    {
        if (KnownNPCs.Contains(npc))
        {
            EnemyNPCs.Add(npc);

            GameMessageScript.Notification(npc.Name + " is your enemy now.", new List<Player> { RefPlayer }, Color.yellow, true);
        }
    }
    //Set InParole
    public void SetParoleState(bool IsInParole)
    {
        InParole = IsInParole;

        GameMessageScript.Notification("You have been released on parole.", new List<Player> { RefPlayer }, Color.yellow, false);
    }
    public void SetParoleEndDate(GameDate endDate)
    {
        ParoleEndDate = endDate;

        GameMessageScript.Notification("You will be released from parole on " + endDate.ToString() + ".", new List<Player> { RefPlayer }, Color.yellow, false);
    }
    //Set InPrison
    public void SetPrisonState(bool IsInPrison)
    {
        InPrison = IsInPrison;

        if (IsInPrison)
        {
            int AddingDay = 1;
            foreach (Trial trial in Trials)
            {
                GameDate newExecuteDate = GameController.gameDate;
                newExecuteDate.AddDay(AddingDay);
                AddingDay++;

                trial.SetExecuteDate(newExecuteDate);
            }

            GameMessageScript.Notification("You have been imprisoned.", new List<Player> { RefPlayer }, Color.red, false);
        }
    }
    public void SetPrisonEndDate(GameDate endDate)
    {
        PrisonEndDate = endDate;

        GameMessageScript.Notification("You will be released on " + endDate.ToString() + ".", new List<Player> { RefPlayer }, Color.blue, true);
    }
    public void SetDeathSentenced(bool isDeathSentenced)
    {
        IsDeathSentenced = isDeathSentenced;

        GameMessageScript.Notification("You got a death sentence!", new List<Player> { RefPlayer }, Color.red, false);
    }
    public void SetExecutionDate(GameDate executionDate)
    {
        ExecutionDate = executionDate;

        GameMessageScript.Notification("You will be executed on " + executionDate.ToString() + ".", new List<Player> { RefPlayer }, Color.red, true);
    }
    //Set IsOnARun
    public void SetRunningState(bool IsRunning)
    {
        IsOnARun = IsRunning;
    }
    //Kill this character
    public void Kill(string reason)
    {
        IsDead = true;

        GameMessageScript.Notification("You are died at age of " + Age + ". Reason: " + reason, new List<Player> { RefPlayer }, Color.black, true);
    }
    //Skill methods below
    public void BusinessLevelUp(byte gainedLevel)
    {
        if (BusinessLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            BusinessLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            BusinessLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Business Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddBusinessLevelXP(byte gainedXP)
    {
        if (!(BusinessLevel == CharacterCapacities.SKILLS_CAP))
        {
            BusinessLevelXP += gainedXP;

            if (BusinessLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                BusinessLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                BusinessLevelUp(1);

                if (BusinessLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddBusinessLevelXP(0);
                }
            }
        }
    }
    public void CharmLevelUp(byte gainedLevel)
    {
        if (CharmLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            CharmLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            CharmLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Charm Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddCharmLevelXP(byte gainedXP)
    {
        if (!(CharmLevel == CharacterCapacities.SKILLS_CAP))
        {
            CharmLevelXP += gainedXP;

            if (CharmLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                CharmLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                CharmLevelUp(1);

                if (CharmLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddCharmLevelXP(0);
                }
            }
        }
    }
    public void IntelligenceLevelUp(byte gainedLevel)
    {
        if (IntelligenceLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            IntelligenceLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            IntelligenceLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Intelligence Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddIntelligenceLevelXP(byte gainedXP)
    {
        if (!(IntelligenceLevel == CharacterCapacities.SKILLS_CAP))
        {
            IntelligenceLevelXP += gainedXP;

            if (IntelligenceLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                IntelligenceLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                IntelligenceLevelUp(1);

                if (IntelligenceLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddIntelligenceLevelXP(0);
                }
            }
        }
    }
    public void PowerLevelUp(byte gainedLevel)
    {
        if (PowerLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            PowerLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            PowerLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Power Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddPowerLevelXP(byte gainedXP)
    {
        if (!(PowerLevel == CharacterCapacities.SKILLS_CAP))
        {
            PowerLevelXP += gainedXP;

            if (PowerLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                PowerLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                PowerLevelUp(1);

                if (PowerLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddPowerLevelXP(0);
                }
            }
        }
    }
    public void StealthLevelUp(byte gainedLevel)
    {
        if (StealthLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            StealthLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            StealthLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Stealth Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddStealthLevelXP(byte gainedXP)
    {
        if (!(StealthLevel == CharacterCapacities.SKILLS_CAP))
        {
            StealthLevelXP += gainedXP;

            if (StealthLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                StealthLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                StealthLevelUp(1);

                if (StealthLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddStealthLevelXP(0);
                }
            }
        }
    }
    public void HandinessLevelUp(byte gainedLevel)
    {
        if (HandinessLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            HandinessLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            HandinessLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Handiness Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddHandinessLevelXP(byte gainedXP)
    {
        if (!(HandinessLevel == CharacterCapacities.SKILLS_CAP))
        {
            HandinessLevelXP += gainedXP;

            if (HandinessLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                HandinessLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                HandinessLevelUp(1);

                if (HandinessLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddHandinessLevelXP(0);
                }
            }
        }
    }
    public void TechLevelUp(byte gainedLevel)
    {
        if (TechLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            TechLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            TechLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Tech Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddTechLevelXP(byte gainedXP)
    {
        if (!(TechLevel == CharacterCapacities.SKILLS_CAP))
        {
            TechLevelXP += gainedXP;

            if (TechLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                TechLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                TechLevelUp(1);

                if (TechLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddTechLevelXP(0);
                }
            }
        }
    }
    public void LabLevelUp(byte gainedLevel)
    {
        if (LabLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            LabLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            LabLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Lab Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddLabLevelXP(byte gainedXP)
    {
        if (!(LabLevel == CharacterCapacities.SKILLS_CAP))
        {
            LabLevelXP += gainedXP;

            if (LabLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                LabLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                LabLevelUp(1);

                if (LabLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddLabLevelXP(0);
                }
            }
        }
    }
    public void FarmerLevelUp(byte gainedLevel)
    {
        if (FarmerLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            FarmerLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            FarmerLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Farmer Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddFarmerLevelXP(byte gainedXP)
    {
        if (!(FarmerLevel == CharacterCapacities.SKILLS_CAP))
        {
            FarmerLevelXP += gainedXP;

            if (FarmerLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                FarmerLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                FarmerLevelUp(1);

                if (FarmerLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddFarmerLevelXP(0);
                }
            }
        }
    }
    public void MethLevelUp(byte gainedLevel)
    {
        if (ProduceMethLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            ProduceMethLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            ProduceMethLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Meth Producing Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddMethLevelXP(byte gainedXP)
    {
        if (!(ProduceMethLevel == CharacterCapacities.SKILLS_CAP))
        {
            ProduceMethLevelXP += gainedXP;

            if (ProduceMethLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                ProduceMethLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                MethLevelUp(1);

                if (ProduceMethLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddMethLevelXP(0);
                }
            }
        }
    }
    public void CocainLevelUp(byte gainedLevel)
    {
        if (ProduceCocainLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            ProduceCocainLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            ProduceCocainLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Cocain Producing Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddCocainLevelXP(byte gainedXP)
    {
        if (!(ProduceCocainLevel == CharacterCapacities.SKILLS_CAP))
        {
            ProduceCocainLevelXP += gainedXP;

            if (ProduceCocainLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                ProduceCocainLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                CocainLevelUp(1);

                if (ProduceCocainLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddCocainLevelXP(0);
                }
            }
        }
    }
    public void WeedLevelUp(byte gainedLevel)
    {
        if (ProduceWeedLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            ProduceWeedLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            ProduceWeedLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Weed Producing Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddWeedLevelXP(byte gainedXP)
    {
        if (!(ProduceWeedLevel == CharacterCapacities.SKILLS_CAP))
        {
            ProduceWeedLevelXP += gainedXP;

            if (ProduceWeedLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                ProduceWeedLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                WeedLevelUp(1);

                if (ProduceWeedLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddWeedLevelXP(0);
                }
            }
        }
    }
    public void MDMALevelUp(byte gainedLevel)
    {
        if (ProduceMDMALevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            ProduceMDMALevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            ProduceMDMALevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " MDMA Producing Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddMDMALevelXP(byte gainedXP)
    {
        if (!(ProduceMDMALevel == CharacterCapacities.SKILLS_CAP))
        {
            ProduceMDMALevelXP += gainedXP;

            if (ProduceMDMALevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                ProduceMDMALevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                MDMALevelUp(1);

                if (ProduceMDMALevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddMDMALevelXP(0);
                }
            }
        }
    }
    public void ConnectionsLevelUp(byte gainedLevel)
    {
        if (ConnectionsLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            ConnectionsLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            ConnectionsLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Connections Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddConnectionsLevelXP(byte gainedXP)
    {
        if (!(ConnectionsLevel == CharacterCapacities.SKILLS_CAP))
        {
            ConnectionsLevelXP += gainedXP;

            if (ConnectionsLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                ConnectionsLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                ConnectionsLevelUp(1);

                if (ConnectionsLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddConnectionsLevelXP(0);
                }
            }
        }
    }
    public void TransportLevelUp(byte gainedLevel)
    {
        if (TransporterLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            TransporterLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            TransporterLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Transport Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddTransportLevelXP(byte gainedXP)
    {
        if (!(TransporterLevel == CharacterCapacities.SKILLS_CAP))
        {
            TransporterLevelXP += gainedXP;

            if (TransporterLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                TransporterLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                TransportLevelUp(1);

                if (TransporterLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddTransportLevelXP(0);
                }
            }
        }
    }
    public void MoneyLaunderingLevelUp(byte gainedLevel)
    {
        if (MoneyLaunderingLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            MoneyLaunderingLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            MoneyLaunderingLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Money Laundering Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddMoneyLaunderingLevelXP(byte gainedXP)
    {
        if (!(MoneyLaunderingLevel == CharacterCapacities.SKILLS_CAP))
        {
            MoneyLaunderingLevelXP += gainedXP;

            if (MoneyLaunderingLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                MoneyLaunderingLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                MoneyLaunderingLevelUp(1);

                if (MoneyLaunderingLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddMoneyLaunderingLevelXP(0);
                }
            }
        }
    }
    public void LawyeringLevelUp(byte gainedLevel)
    {
        if (LawyeringLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            LawyeringLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            LawyeringLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Lawyering Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddLawyeringLevelXP(byte gainedXP)
    {
        if (!(LawyeringLevel == CharacterCapacities.SKILLS_CAP))
        {
            LawyeringLevelXP += gainedXP;

            if (LawyeringLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                LawyeringLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                LawyeringLevelUp(1);

                if (LawyeringLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddLawyeringLevelXP(0);
                }
            }
        }
    }
    public void OperatingLevelUp(byte gainedLevel)
    {
        if (OperatingLevel + gainedLevel >= CharacterCapacities.SKILLS_CAP)
        {
            OperatingLevel = CharacterCapacities.SKILLS_CAP;
        }
        else
        {
            OperatingLevel += gainedLevel;
            GameMessageScript.Notification("+" + gainedLevel + " Operating Level.", new List<Player> { RefPlayer }, Color.green, true);
        }
    }
    public void AddOperatingLevelXP(byte gainedXP)
    {
        if (!(OperatingLevel == CharacterCapacities.SKILLS_CAP))
        {
            OperatingLevelXP += gainedXP;

            if (OperatingLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
            {
                OperatingLevelXP -= CharacterCapacities.SKILLS_XP_CAP;
                OperatingLevelUp(1);

                if (OperatingLevelXP >= CharacterCapacities.SKILLS_XP_CAP)
                {
                    AddOperatingLevelXP(0);
                }
            }
        }
    }
    //Methods for skill-conditioners
    public void SwitchStyle(bool likesLoud)
    {
        LikesLoudStyle = likesLoud;
    }
    public void SwitchScientist(bool isScientist)
    {
        //Notify player
        if (IsScientist == false && isScientist == true)
        {
            GameMessageScript.Notification("You are now considered as scientist.", new List<Player> { RefPlayer }, Color.green, false);
        }
        else if (IsScientist == true && isScientist == false)
        {
            GameMessageScript.Notification("You are no longer considered as scientist.", new List<Player> { RefPlayer }, Color.green, false);
        }

        IsScientist = isScientist;
    }
    public void SwitchAccountant(bool isAccountant)
    {
        //Notify player
        if (IsAccountant == false && isAccountant == true)
        {
            GameMessageScript.Notification("You are now considered as accountant.", new List<Player> { RefPlayer }, Color.green, false);
        }
        else if (IsAccountant == true && isAccountant == false)
        {
            GameMessageScript.Notification("You are no longer considered as accountant.", new List<Player> { RefPlayer }, Color.green, false);
        }

        IsAccountant = isAccountant;
    }
    public void SwitchLawyer(bool isLawyer)
    {
        //Notify player
        if (BarPass == false && isLawyer == true)
        {
            GameMessageScript.Notification("You are now considered as lawyer.", new List<Player> { RefPlayer }, Color.green, false);
        }
        else if (BarPass == true && isLawyer == false)
        {
            GameMessageScript.Notification("You are no longer considered as lawyer.", new List<Player> { RefPlayer }, Color.green, false);
        }

        BarPass = isLawyer;
    }
    #endregion
}

public class Player : BaseCharacter
{
    #region Declerations
    public ulong MoneyDollar { get; set; } //Cap 99.999.999.999
    public ulong DirtyMoneyDollar { get; set; } //Cap 99.999.999.999
    public uint PerkPoints { get; set; }
    public List<CharacterPerk> Perks { get; set; }
    #endregion

    #region Constructor Method
    public Player()
    {
        //Main
        MoneyDollar = 0;
        DirtyMoneyDollar = 0;
        PerkPoints = 0;
        Perks = new List<CharacterPerk>();

        RefPlayer = this;
    }
    #endregion

    #region Methods
    public void AddDollar(ulong amount)
    {
        if (MoneyDollar + amount >= PlayerMoneyCapacities.MAX_MONEY)
        {
            MoneyDollar = PlayerMoneyCapacities.MAX_MONEY;
        }
        else
        {
            MoneyDollar += amount;

            GameMessageScript.Notification("+" + amount + "$", new List<Player> { this }, Color.green, true);
        }
    }
    public void RemoveDollar(ulong amount)
    {
        if (MoneyDollar - amount <= 0)
        {
            MoneyDollar = 0;
        }
        else
        {
            MoneyDollar -= amount;

            GameMessageScript.Notification("-" + amount + "$", new List<Player> { this }, Color.red, true);
        }
    }
    public void AddDirtyDollar(ulong amount)
    {
        if (DirtyMoneyDollar + amount >= PlayerMoneyCapacities.MAX_MONEY)
        {
            DirtyMoneyDollar = PlayerMoneyCapacities.MAX_MONEY;
        }
        else
        {
            DirtyMoneyDollar += amount;

            GameMessageScript.Notification("+" + amount + "$ (Dirty)", new List<Player> { this }, Color.green, true);
        }
    }
    public void RemoveDirtyDollar(ulong amount)
    {
        if (DirtyMoneyDollar - amount <= 0)
        {
            DirtyMoneyDollar = 0;
        }
        else
        {
            DirtyMoneyDollar -= amount;

            GameMessageScript.Notification("-" + amount + "$ (Dirty)", new List<Player> { this }, Color.red, true);
        }
    }
    public void TransferMoney(ulong amount, Player target)
    {
        if (MoneyDollar >= amount && target != null)
        {
            MoneyDollar -= amount;
            target.MoneyDollar += amount;

            GameMessageScript.Notification(amount + "$ is transferred to " + target.Name + ".", new List<Player> { this }, Color.blue, true);
            GameMessageScript.Notification(amount + "$ is transferred to you by " + Name + ".", new List<Player> { target }, Color.blue, true);
        }
    }
    public void TransferDirtyMoney(ulong amount, Player target)
    {
        if (DirtyMoneyDollar >= amount && target != null)
        {
            DirtyMoneyDollar -= amount;
            target.DirtyMoneyDollar += amount;

            GameMessageScript.Notification(amount + "$ (Dirty) is transferred to " + target.Name + ".", new List<Player> { this }, Color.blue, true);
            GameMessageScript.Notification(amount + "$ (Dirty) is transferred to you by " + Name + ".", new List<Player> { target }, Color.blue, true);
        }
    }

    public void AddPerkPoint(byte amount)
    {
        PerkPoints = Convert.ToUInt(PerkPoints + amount);

        GameMessageScript.Notification(amount + " perk points gained.", new List<Player> { this }, Color.green, false);
    }
    public void AddPerk(CharacterPerk newPerk)
    {
        Perks.Add(newPerk);

        GameMessageScript.Notification(newPerk.Name + " (Perk) is now active.", new List<Player> { this }, Color.green, true);
    }
    #endregion
}
public class NPC : BaseCharacter
{
    #region Declerations
    public byte FocusIndex { get; set; } // 0 is all
    #endregion

    #region Constructor Method
    public NPC()
    {
        FocusIndex = 0;

        RefNPC = this;
    }
    #endregion

    #region Methods
    //Focus Index Methods
    public string FocusIndexToString()
    {
        switch (FocusIndex)
        {
            case 1:
                return "Business";
            case 2:
                return "Robberies";
            case 3:
                return "Hitman";
            case 4:
                return "Illegal Producing";
            case 5:
                return "Drug Dealing";
            case 6:
                return "Smuggling";
            case 7:
                return "Money Laundering";
            case 8:
                return "Legal Supporting";
            case 9:
                return "Middle Man";
            default:
                return "All";
        }
    }
    #endregion
}
#endregion
