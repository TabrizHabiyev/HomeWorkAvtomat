using System;
using System.Collections.Generic;
using System.Text;

namespace Avtomat
{
    class Kalashnikov
    {
        public Kalashnikov()
        {
            string Avto = "";
            Console.WriteLine("Silahdan tek tek yoxsa avtomatik rejimde ates edeceksiz? Avtomatik rejim ucun 'Avto' tek-tek atis ucun 'Tek' acar sozlerinden birini daxil edin");
            Avto = Console.ReadLine().ToLower();
            //Avtomatik yoxsa tektek atis edeceyini sorusuruq.
                    switch (Avto)
                    {
                        case "avto":
                            AvtomatikAtis();
                            break;
                        case "tek":
                            TektekAtis();
                            break;

                        default:
                            Console.WriteLine("Daxil etdiyiniz acar soz yalnisdir.Yeniden davam etmek ucun 'Yes'  acar sozunu daxil edin.Eks halda entere klikleyin");
                            string again = "";
                            again = Console.ReadLine().ToLower();
                            if (again == "yes")
                            {
                                Kalashnikov kalashnikov = new Kalashnikov();
                            }
                            else if (again !="yes")
                            {
                                Console.WriteLine("Sagolun");
                            }
                            break;
                    }
        }


        public void AvtomatikAtis() //Avtomatik atis methodu
        {
            int GulleSayi;//Avtomatda hazirda olan gulle sayi
            int DaxilEdilenGulle;//Avtomata elae edilecek gulle sayi
            //Avtomatda hazirda olan gulle sayin daxil edirik.
            Console.WriteLine("Avtomatda hazirda nece gulle var?");
            GulleSayi = Convert.ToInt32(Console.ReadLine());
            //Avtomata elave edeceyimiz elave gulle sayin daxil edirik.
            Console.WriteLine("Avtomata nece gulle daxil etmek isteyirsiz?");
            DaxilEdilenGulle = Convert.ToInt32(Console.ReadLine());
            //gelen butun melumatlari control ucun controller methoduna gonderirik.
            AvtoAtesController(GulleSayi,DaxilEdilenGulle);
            
        }

        public void TektekAtis() //Tektek atis methodu
        {
            int GulleSayi; //Avtomatda hazirda olan gulle sayi
            int DaxilEdilenGulle;//Avtomata elave etmek istediyimiz gulle sayi
            int NeceGulleAtilacaq;//Avtomatdan atilacaq gulle sayi
            //Avtomatda hazirda olan gulle sayin daxil edirik.
            Console.WriteLine("Avtomatda hazirda nece gulle var?");
            GulleSayi = Convert.ToInt32(Console.ReadLine());
            //Avtomata elave edeceyimiz elave gulle sayin daxil edirik.
            Console.WriteLine("Avtomata nece gulle daxil etmek isteyirsiz?");
            DaxilEdilenGulle = Convert.ToInt32(Console.ReadLine());
            //Avtomatan nece defe ates acilacagin sorusuruq
            Console.WriteLine("Nece defe ates etmek isteyirsiz ?");
            NeceGulleAtilacaq= Convert.ToInt32(Console.ReadLine());
            //Gelen butun melumatlari conrol ucun controller metoduna gonderirik.
            TektekAtesController(GulleSayi, DaxilEdilenGulle, NeceGulleAtilacaq);
        }



        public void AvtoAtesController(int GulleSayi,int DaxilEdilenGulle) 
        {  //Avtomatik atis ucun conroller
            string YesOrNo = "";
            int max = GulleSayi + DaxilEdilenGulle;
            if (max > 30)//Umumi gulle sayi 30 u kecmemelidi
            {
                string again = "";
                Console.WriteLine($"Avtomat gulle tutumu max 30 dur.Siz daxil etmek istediz {max} gulle. ");
                Console.WriteLine("Yeniden Ceht etmek ucun 'Y' Acar sozunu daxil edin eks halda entere klikleyin");
                again = Console.ReadLine().ToLower();
                if (again == "y")//Isteye gore Consractoru yeniden basladiriq
                {
                    Kalashnikov yeniden = new Kalashnikov();
                }
            }
            if (max < 30 || max == 30)
            {
                //Ates acib acmaq istemediyimizi secirik
                Console.WriteLine("Ates etmek isteyirsiz? istiyirsizse 'Y' acar sozun daxil edin .Eks halda entere klikleyin");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo == "y")
                {
                    Console.WriteLine($"Avtomatdan avtomatik rejimde {max} ates acildi . Qalan gulle sayi 0");
                    Console.WriteLine("Yeniden silahi test etmek isteyirsiz ? istiyirsizse 'Y' acar sozun daxil edin .Eks halda entere klikleyin");
                    YesOrNo = Console.ReadLine().ToLower();
                    if (YesOrNo == "y")//Isteye gore Consractoru yeniden basladiriq
                    {
                        Kalashnikov again = new Kalashnikov();
                    }

                }
            }
        }

        //// Tek tek ates ucun Controller Method
        public void TektekAtesController(int GulleSayi, int DaxilEdilenGulle,int NeceGulleAtilacaq)
        {  
         string YesOrNo = "";
            int max = GulleSayi + DaxilEdilenGulle;
            if (NeceGulleAtilacaq>max)
            {
                Console.WriteLine($"Avtoma {max} gulle var.Sizin ates etmek istediyiniz gulle sayi {NeceGulleAtilacaq}");
                Console.WriteLine("Yeniden ceht etmek ucun 'Y' acar sozunu daxil edin.Eks halda entere klikleyin");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo=="y")//Isteye gore Consractoru yeniden basladiriq
                {
                    Kalashnikov again = new Kalashnikov();
                }
            }
            else if (max > 30)
            {
                Console.WriteLine($"Avtomatin max gulle tutumu 30 gulle.Siz daxil etmek istediz {max} gulle");
                Console.WriteLine("Yeniden ceht etmek ucun 'Y' acar sozunu daxil edin.Eks halda entere klikleyin");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo == "y")//Isteye gore Consractoru yeniden basladiriq
                {
                    Kalashnikov again = new Kalashnikov();
                }
            }
            else if (max < 30 || max ==30)
            {
                Console.WriteLine("Ates etmek isteyirsiz? istiyirsizse 'Y' acar sozun daxil edin .Eks halda entere klikleyin");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo=="y")
                {
                    Console.WriteLine($"Avtomatdan tektek ates rejiminde {NeceGulleAtilacaq} gulle atildi.Avtomatda hazirda {max - NeceGulleAtilacaq} gulle qaldi");
                }
               
            }
        
        }
    }
}

