
class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("******* Analýza textu ***********");
            Console.WriteLine("*********************************");
            Console.WriteLine("***** Lucie Stejskalová *********");
            Console.WriteLine("*****************************\n\n");

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();
            
            
                string samohlasky = "aáeéěiíoóuůúyýAÁEÉĚIÍOÓUŮÚYÝ";
                string souhlasky = "bcčdďfghjklmnpqrřsštťuvwxzžBCČDĎFGHJKLMNPRQRŘSŠTŤUVWXZŽ";
                string cislice = "0123456789";


                int pocetSamohlasek = 0;
                int pocetSouhlasek = 0;
                int pocetCislic = 0;
                int pocetOstatnich = 0;

                foreach(char znak in myText){
                    if(souhlasky.Contains(znak)){
                        pocetSouhlasek++;
                    }
                    else if(samohlasky.Contains(znak)){
                        pocetSamohlasek++;
                    }
                    else if(cislice.Contains(znak)){
                        pocetCislic++;
                    }
                    else{
                        pocetOstatnich++;   
                    }
                        
                
                
                }



                Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek);
                Console.WriteLine("Počet souhlásek:{0}", pocetSouhlasek);
                Console.WriteLine("Počet číslic:{0}", pocetCislic);
                Console.WriteLine("Počet ostatních znaků:{0}", pocetOstatnich);

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
        }
    }   


