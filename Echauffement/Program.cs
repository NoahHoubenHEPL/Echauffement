using System.ComponentModel.Design;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour, je suis Noah et mon jeu préféré est Minecraft");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est votre prénom?");
        string firstName = Console.ReadLine();
        Console.WriteLine("Bonjour, " + firstName + ", quel age avez-vous?");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age > 17)
        {
            Console.WriteLine("Tu es majeur");
        }
        else
        {
            Console.WriteLine("Tu es mineur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euro avez-vous?");
        int money = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("1. Couteau: 4,00");
        Console.WriteLine("2. Katana: 24,00");
        Console.WriteLine("3. Pistolet: 36,00");
        Console.WriteLine("4. Revolver: 45,00");
        Console.WriteLine("Quelle arme voulez-vous?");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        int weapon = Convert.ToInt32(Console.ReadLine());
        string weaponType = "nil";
        int weaponPrice = 0;
        if (weapon == 1)
        {
            weaponType = "Couteau";  
            weaponPrice = 4;
        }
        if (weapon == 2)
        {
            weaponType = "Katana";
            weaponPrice = 24;
        }
        if (weapon == 3)
        {
            weaponType = "Pistolet";
            weaponPrice = 36;
        }
        if (weapon == 4)
        {
            weaponType = "Revolver";
            weaponPrice = 45;
        }
        Console.WriteLine("Vous avez choisi: " + weaponType + " qui coute " + weaponPrice + ".00");
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if ((money > weaponPrice) && age > 17)
        {
            Console.WriteLine(weaponType + "à été acheté avec succès, votre balance est à " + (money - weaponPrice) + ".00");
        }
        else 
        {
            Console.WriteLine("L'action n'a pas été possible, verifiez que vous avez bien plus de 18ans et assez d'argent");
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
            // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
            
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}