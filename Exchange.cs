using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUser
{
    class Exchange
    {
        public User receiver { get; set; }
        public Product produit { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public bool connexBD { get; set; }
        public bool compoEnvoieMail { get;set; }

        public bool testConnexBD(string chaine)
        {
            if (chaine.Length < 1234) {
                /// On ajoute le comportement pour vérifier si la connexion est possible
                return connexBD = true;
            }
            else
            {
                return connexBD = false;
            }
        }

        public bool testEnvoieMail(int age)
        {
            if (age < 18)
            {
                /// On ajoute le comportement pour vérifier si l'envoie est possible
                return compoEnvoieMail = true;
            }
            else
            {
                return compoEnvoieMail = false;
            }
        }

        public bool save()
        {
            if (receiver.isValid() && testConnexBD("test") && testEnvoieMail(this.produit.user.age) && dateStart < DateTime.Now && dateStart < dateEnd ) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
