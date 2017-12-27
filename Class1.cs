using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        int money = 0;
        int luck = 999;
        int life = 100;

        static IDictionary<int, string> CEsOne = new Dictionary<int, string>()
                                                            {
                                                                {1,"Green Black Keys"},
                                                                {2,"Red Black Keys"},
                                                                {3,"Blue Black Keyes"},
                                                                {4,"Hermitage"},
                                                                {5, "Atlas Academy"},
                                                                {6,"Rin's Pendant"},
                                                                {7,"Grimoire"},
                                                                {8, "Fragarach"},
                                                                {9,"Mystery Masks"},
                                                                {10,"Green Black Keys"},
                                                                {12, "Starlight Fest"},
                                                                {13,"False Attendant"},
                                                                {14,"Runestones"},
                                                                {15, "Lugh's Halo"},
                                                                {16,"Moon Cell"},
                                                                {17,"Elixir"},
                                                                {18, "Shinji-Kun"},
                                                                {19,"Magic Meter"},
                                                                {20,"Storch Ritter"},
                                                                {21, "Motorcycle"},
                                                                {22,"Bronze Link Hand"},
                                                                {23,"Azoth Blade"},
                                                                {24, "Church of Rubble"},
                                                                {25,"Ship CE"},
                                                                {26,"Red Sea"},
                                                                {27, "Stuffed Lion"},
                                                                {28,"True Shot"},
                                                                {29,"Self Geass Scroll"},
                                                                {30, "Traces of Dreams"},
                                                                {31,"Elixir of Love"},
                                                                {32,"Hydra Dagger"},
                                                                {33, "Law of the Jungle"},
                                                                {34,"Demon Boar"},
                                                                {35,"Ath nGabla"},
                                                                {36,"Mapo Tofu"}
                                                            };



        static IDictionary<int, string> CEsTwo = new Dictionary<int, string>()
                                                            {
                                                                {1,"Steel Training"},
                                                                {2, "Gentle Affection"},
                                                                {3,"Golden Millenium Tree"},
                                                                {4,"Number Magecraft"},
                                                                {5, "Divine Banquet"},
                                                                {6,"Angel's Poem"},
                                                                {7,"Awakened Will"},
                                                                {8, "Young Maiden"},
                                                                {9,"Sealing Enforcer"},
                                                                {10,"Room Guarder"},
                                                                {11, "Primevel Magic"},
                                                                {12,"Necromancy"},
                                                                {13,"Record Holder"},
                                                                {14,"Gandr"},
                                                                {15, "Projection Magecraft"},
                                                                {16,"Verdant Sound"},
                                                                {17,"Gem Magecraft"},
                                                                {18, "Code Cast"},
                                                                {19,"Kill on Sight"},
                                                                {20,"White Cruising"},
                                                                {21, "With One Strike"}     
                                                            };


        static IDictionary<int, string> servantsOne = new Dictionary<int, string>()
                                                            {
                                                                {1,"Robin Hood"},
                                                                {2, "Eurayle"},
                                                                {3,"Kiyohime"},
                                                                {4,"Saber Gilles"},
                                                                {5, "Caster Gilles"},
                                                                {6,"David"},
                                                                {7,"Medea"},
                                                                {8, "Cu Lancer"},
                                                                {9,"Cu Caster"},
                                                                {10,"Medusa"},
                                                                {11, "Ushiwakamaru"},
                                                                {12,"Kid Gil"},
                                                                {13,"Jing Ke"},
                                                                {14, "Darius III"},
                                                                {15,"Serenity"},
                                                                {16,"Boudica"},
                                                                {17, "Billy the Kid"},
                                                                {18,"Fergus"},
                                                                {19,"Hundred Face"},
                                                                {20, "Romulus"},
                                                                {21,"Touta"},
                                                                {22,"Lu Bu"},
                                                                {23, "Caesar"},
                                                                {24,"Geronimo"},
                                                                {25, "Jerkyll and Hyde"},
                                                                {26, "Eurayle"},
                                                                {27,"Jaguar Man"},
                                                                {28,"Diarmuid"},
                                                                {29, "Cu Prototype"},
                                                                {30,"Babbage"},
                                                                {31,"Inshun"},
                                                                {32, "Alexander"},
                                                                {33,"Mephistopheles"},
                                                                {34, "Parsceleus"},
                                                                {35, "Fuuma Kotaru"}
                                                            };


        static IDictionary<int, string> servantsTwo = new Dictionary<int, string>()
                                                            {
                                                                {1,"Siegfried"},
                                                                {2, "Stheno"},
                                                                {3,"Herc"},
                                                                {4,"Nero"},
                                                                {5, "Emiya"},
                                                                {6,"Marie"},
                                                                {7,"Medea Lily"},
                                                                {8, "Saber Alter"},
                                                                {9,"Saber Alter Lancer"},
                                                                {10,"Nitocris"},
                                                                {11, "Medusa Lily"},
                                                                {12,"D'Eon"},
                                                                {13,"Anne and Mary"},
                                                                {14, "Carmilla"},
                                                                {15,"Elizabeth"},
                                                                {16,"Parvati"},
                                                                {17, "Penthesilea"},
                                                                {18,"Queen of Sheba"},
                                                                {19,"Wu Zetian"},
                                                                {20, "Tristan"},
                                                                {21,"Lancelot"},
                                                                {22,"Gawain"},
                                                                {23, "Beserkerlot"},
                                                                {24,"Emiya Assassin"},
                                                                {25, "Li Shuwen"},
                                                                {26, "Yagyu"},
                                                                {27,"Suzuka Gohen"},
                                                                {28,"Circe"},
                                                                {29, "Yang Qing"},
                                                                {30,"Emiya Alter"},
                                                                {31,"Kato Danzo"},
                                                                {32, "Tomoe Gozen"},
                                                                {33,"Hessian Lobo"},
                                                                {34,"Hercules"},
                                                                {35,"Nezha"},
                                                                {36, "Nursery Rhyme"},
                                                                {37,"Gorgon"},
                                                                {38,"Gilgamesh"},
                                                                {39,"Frakenstein"}

                                                            };

        static IDictionary<int, string> servantsThree = new Dictionary<int, string>()
                                                            {
                                                                {1,"Altera"},
                                                                {2, "Artoria"},
                                                                {3,"Arjuna"},
                                                                {4,"Karna"},
                                                                {5, "Vlad III"},
                                                                {6,"Waver"},
                                                                {7,"Orion"},
                                                                {8, "Sanzo"},
                                                                {9,"Francis Drake"},
                                                                {10,"Tamamo"},
                                                                {11, "Osakabehime"},
                                                                {12,"Scherazarde"},
                                                                {13,"Nightingale"},
                                                                {14, "Mordred"},
                                                                {15,"Medb"},
                                                                {16,"Cu Alter"},
                                                                {17, "Nikola Tesla"},
                                                                {18,"Enkidu"},
                                                                {19,"Quetz"},
                                                                {20, "Artoria Lancer"},
                                                                {21,"Lancelot"},
                                                                {22,"Ozymandias"},
                                                                {23, "Jack the Ripper"},
                                                                {24,"Jeanne D'Arc"}
                                                                
                                                          };

        public static void rollTest()
        {
            Random random = new Random();
            int times = 10;
            int counter = 0;

            Console.WriteLine(servantsThree[5]);
            while (counter != times)
            {
                int randomNumber = random.Next(0, 101);
                int randomCEone = random.Next(1, 37);
                int randomCEtwo = random.Next(1, 22);
                //int randomCEthree = random.Next(0, 101);
                int randomOne = random.Next(1, 36);
                int randomTwo = random.Next(1, 40);
                int randomThree = random.Next(1, 25);
                
                if (randomNumber <= 40)
                {
                    Console.WriteLine(randomNumber + " You got: " + CEsOne[randomCEone]);
                }

                else if (randomNumber > 40 && randomNumber <= 80)
                {
                    Console.WriteLine(randomNumber + " You got: " + servantsOne[randomOne]);
                }

                else if (randomNumber > 80 && randomNumber <= 92)
                {
                    Console.WriteLine(randomNumber + " You got: " + CEsTwo[randomCEtwo]);
                }

                else if (randomNumber > 92 && randomNumber <= 95)
                {
                    Console.WriteLine(randomNumber + " You got a four star servant!!: " + servantsTwo[randomTwo]);
                }

                else if (randomNumber > 95 && randomNumber <= 99)
                {
                    Console.WriteLine(randomNumber + " You got a five star CE!");
                }

                else if (randomNumber == 100)
                {
                    Console.WriteLine(randomNumber + " WOW!!!! You got a five star servant!!: " + servantsThree[randomThree]);
                }
                counter++;
            }
        }
    }
}
