using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void WriteCenter(string text)
    {
        int leftPadding = (Console.WindowWidth - text.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(0, leftPadding)) + text);
    }

    static void Main()
    {
        bool state;
        while (state = true)
        {
            string choosen;
            int choice = 0;

            string lang;
            int language = 0;

            string filterValue = "";
            string filterType = "";


            string[] lines = File.ReadAllLines("musiques.csv");

            List<Music> songs = new List<Music>();

            foreach (string line in lines.Skip(1))
            {
                string[] cols = line.Split(';');
                int.TryParse(cols[3], out int year);


                Music m = new Music();
                m.Title = cols[0];
                m.Artist = cols[1];
                m.Genre = cols[2];
                m.Year = year;
                m.Language = cols[4];
                m.Idioma = cols[5];
                m.Langue = cols[6];
                m.Mood = cols[7];
                m.Humor = cols[8];
                m.Humour = cols[9];
                m.Album = cols[10];

                songs.Add(m);
            }
            WriteCenter("");
            WriteCenter("╔═════════════════════════════════════════════╗");
            WriteCenter("║ ♫ -- Welcome | Bem-Vindo | Bievenue :) -- ♫ ║");
            WriteCenter("╚═════════════════════════════════════════════╝");
            WriteCenter("");
            WriteCenter("Choose a language | Escolha um idioma | Choisissez une langue : ");
            WriteCenter("1) English  2) Português  3) Français");
            WriteCenter("");
            Console.Write("                                                       ");
            lang = Console.ReadLine();

            if (int.TryParse(lang, out language))
            {
                if (language == 1)
                {
                    Console.Clear();
                    WriteCenter("");
                    WriteCenter("Welcome to the playlist sorter, you can upload your playlist in a csv file (Update to come on February 30th), you'll be");
                    WriteCenter("able to get an aleatory song based on your choosen filter, like your day mood for example :)");
                    WriteCenter("");
                    WriteCenter("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
                    WriteCenter("");
                    WriteCenter("Filter by: ");
                    WriteCenter("1) Genre  2) Year  3) Language  4) Mood");
                    WriteCenter("");
                    Console.Write("                                                          ");
                    choosen = Console.ReadLine();

                    if (int.TryParse(choosen, out choice))
                    {
                        if (choice == 4)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choose between these options : ");
                            WriteCenter("");
                            WriteCenter("Happy | Romantic | Emotional | Dark | Anxious | Confident | Chaotic | Fun | Melancholic | Hopeful");
                            WriteCenter("Rebellious | Sad | Dreamy | Nostalgic | Energetic | Euphoric | Frustrated | Jealous | Angry | Party");
                            WriteCenter("Sarcastic | Confused | Critical | Bittersweet | Insecure | Ironic | Playful");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                                Type here : ");
                            filterValue = Console.ReadLine();
                            filterType = "mood";
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choose between these options : ");
                            WriteCenter("");
                            WriteCenter("Portuguese | English | French | Spanish | Italian");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                                Type here : ");
                            filterValue = Console.ReadLine();
                            filterType = "language";
                        }
                        else if (choice == 1)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choose between these options : ");
                            WriteCenter("");
                            WriteCenter("Pop | Pop Rock | Country | MPB | Funk | Samba | Indie | Reggaeton | Pagode | RB");
                            WriteCenter("Rock | Latino | Rap | Folk | Hip-Hop | Country Pop | R&B | Soul | Alternative");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                                Type here : ");
                            filterValue = Console.ReadLine();
                            filterType = "genre";
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Type a Year ♫");
                            Console.Write("                                                     Here : ");
                            filterValue = Console.ReadLine();
                            filterType = "ano";

                        }

                    }
                }

                if (language == 2)
                {
                    Console.Clear();
                    WriteCenter("");
                    WriteCenter("Bem-vindo ao sorteador de playlist. Pode submeter a sua playlist num arquivo CSV (atualização prevista para 30 de");
                    WriteCenter("fevereiro) e poderá obter uma música aleatória com base no filtro escolhido, como o seu humor do dia, por exemplo :)");
                    WriteCenter("");
                    WriteCenter("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
                    WriteCenter("");
                    WriteCenter("♫ Filtrar por : ");
                    WriteCenter("1) Gênero  2) Ano  3) Idioma  4) Humor");
                    WriteCenter("");
                    Console.Write("                                                          ");
                    choosen = Console.ReadLine();

                    if (int.TryParse(choosen, out choice))
                    {
                        if (choice == 4)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Escolha entre essas opções : ");
                            WriteCenter("");
                            WriteCenter("Feliz | Romântico | Emocional | Sombrio | Ansioso | Confiante | Caótico | Divertido | Melancólico | Esperançoso");
                            WriteCenter("Rebelde | Triste | Sonhador | Nostálgico | Energético | Eufórico | Frustrado | Ciumento | Raiva | Festa");
                            WriteCenter("Sarcástico | Confuso | Crítico | Agridoce | Inseguro | Irônico | Brincalhão");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                             Digite aqui : ");
                            filterValue = Console.ReadLine();
                            filterType = "humor";
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Escolha entre essas opções : ");
                            WriteCenter("");
                            WriteCenter("Português | Inglês | Francês | Espanhol | Italiano");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                             Digite aqui : ");
                            filterValue = Console.ReadLine();
                            filterType = "idioma";
                        }
                        else if (choice == 1)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Escolha entre essas opções : ");
                            WriteCenter("");
                            WriteCenter("Pop | Pop Rock | Country | MPB | Funk | Samba | Indie | Reggaeton | Pagode | RB");
                            WriteCenter("Rock | Latino | Rap | Folk | Hip-Hop | Country Pop | R&B | Soul | Alternative");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                             Digite aqui : ");
                            filterValue = Console.ReadLine();
                            filterType = "genre";
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Digite um Ano ♫");
                            Console.Write("                                                     Aqui : ");
                            filterValue = Console.ReadLine();
                            filterType = "ano";

                        }
                    }
                }

                if (language == 3)
                {
                    Console.Clear();
                    WriteCenter("");
                    WriteCenter("Bienvenue au Playlist Sorter. Vous pouvez importer votre playlist en fichier CSV (mise à jour prévue le 30.02)");
                    WriteCenter("et vous pourrez obtenir une chanson au hasard selon filtre choisi, comme votre humeur du jour par exemple :)");
                    WriteCenter("");
                    WriteCenter("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
                    WriteCenter("");
                    WriteCenter("♫ Filtrer par :");
                    WriteCenter("1) Genre  2) Année  3) Langue  4) Humour");
                    WriteCenter("");
                    Console.Write("                                                          ");
                    choosen = Console.ReadLine();

                    if (int.TryParse(choosen, out choice))
                    {
                        if (choice == 4)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choisissez entre ces options : ");
                            WriteCenter("");
                            WriteCenter("Heureux | Romantique | Émotionnel | Sombre | Anxieux | Confiant | Chaotique | Amusant | Mélancolique");
                            WriteCenter("Plein d'espoir | Rebelle | Triste | Rêveur | Nostalgique | Énergique | Euphorique | Frustré | Jaloux");
                            WriteCenter("En colère | Fête | Sarcastique | Confus | Critique | Doux-amer | Insécurisé | Ironique | Enjoué");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                               Tapez Ici : ");
                            filterValue = Console.ReadLine();
                            filterType = "humour";
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choisissez entre ces options : ");
                            WriteCenter("");
                            WriteCenter("Portugais | Anglais | Français | Espagnol | Italien");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                               Tapez Ici : ");
                            filterValue = Console.ReadLine();
                            filterType = "langue";
                        }
                        else if (choice == 1)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Choisissez entre ces options : ");
                            WriteCenter("");
                            WriteCenter("Pop | Pop Rock | Country | MPB | Funk | Samba");
                            WriteCenter("Indie | Reggaeton | Pagode | RB | Rock | Latino");
                            WriteCenter("Rap | Folk | Hip-Hop | Country Pop | R&B | Soul");
                            WriteCenter("Alternative");
                            WriteCenter("");
                            WriteCenter("");
                            Console.Write("                                                Tapez Ici : ");
                            filterValue = Console.ReadLine();
                            filterType = "genre";
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            WriteCenter("");
                            WriteCenter("♫ Tappez une anéee ♫");
                            Console.Write("                                                     Ici : ");
                            filterValue = Console.ReadLine();
                            filterType = "ano";

                        }

                    }
                }

                List<Music> results = new List<Music>();

                if (filterType == "genre")
                {
                    results = songs.Where(s => s.Genre == filterValue).ToList();
                }
                else if (filterType == "year" || filterType == "ano" || filterType == "annee")
                {
                    results = songs.Where(s => s.Year.ToString() == filterValue).ToList();
                }
                else if (filterType == "language")
                {
                    results = songs.Where(s => s.Language == filterValue).ToList();
                }
                else if (filterType == "idioma")
                {
                    results = songs.Where(s => s.Idioma == filterValue).ToList();
                }
                else if (filterType == "langue")
                {
                    results = songs.Where(s => s.Langue == filterValue).ToList();
                }
                else if (filterType == "mood")
                {
                    results = songs.Where(s => s.Mood == filterValue).ToList();
                }
                else if (filterType == "humor")
                {
                    results = songs.Where(s => s.Humor == filterValue).ToList();
                }
                else if (filterType == "humour")
                {
                    results = songs.Where(s => s.Humour == filterValue).ToList();
                }

                if (results.Count == 0)
                {
                    WriteCenter("");
                    WriteCenter("");
                    WriteCenter("");
                    WriteCenter("No Results | Sem Resultados | Pas de resultat");
                    Console.WriteLine("\n\n\n\n\n\nR) Restart | Recomeçar | Recommencer");
                    Console.WriteLine("S) Stop | Parar | Arreter");
                    ConsoleKeyInfo touche = Console.ReadKey();
                    if (touche.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        state = true;
                    }
                    if (touche.Key == ConsoleKey.S)
                    {
                        state = false;
                        break;
                    }
                }
                else
                {
                    Music picked = results[new Random().Next(0, results.Count)];
                    Console.Clear();
                    WriteCenter("");
                    WriteCenter("");
                    WriteCenter("♫ " + picked.Title + " ♫");
                    WriteCenter(picked.Artist);
                    WriteCenter("");
                    WriteCenter(picked.Album + " " + "(" + picked.Year.ToString() + ")");
                }

                Console.WriteLine("\n\n\n\n\n\nR) Restart | Recomeçar | Recommencer");
                Console.WriteLine("S) Stop | Parar | Arreter");
                ConsoleKeyInfo touch = Console.ReadKey();
                if (touch.Key == ConsoleKey.R)
                {
                    Console.Clear();
                    state = true;
                }
                if (touch.Key == ConsoleKey.S)
                {
                    state = false;
                    break;
                }
            }
        }
    }



    class Music
    {
        public string Title;
        public string Artist;
        public string Genre;
        public int Year;
        public string Language;
        public string Idioma;
        public string Langue;
        public string Mood;
        public string Humor;
        public string Humour;
        public string Album;
    }
}