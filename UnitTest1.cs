using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace testUser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserInfoAllOk()
        {
            User personne = new User();
            personne.age = 20;
            personne.email = "longuetk@gmail.com";
            personne.nom = "longuet";
            personne.prenom = "kevin";
            Assert.AreEqual(personne.isValid(), true);
        }

        [TestMethod]
        public void TestUserInfoAge()
        {
            User personne = new User();
            personne.age = 10;
            personne.email = "longuetk@gmail.com";
            personne.nom = "longuet";
            personne.prenom = "kevin";
            Assert.AreEqual(personne.isValid(), false);
        }

        [TestMethod]
        public void TestUserInfoEmailFlood()
        {
            User personne = new User();
            personne.age = 20;
            personne.email = "lofqsdfqfq";
            personne.nom = "longuet";
            personne.prenom = "kevin";
            Assert.AreEqual(personne.isValid(), false);
        }

        [TestMethod]
        public void TestUserInfoEmailArobaseFin()
        {
            User personne = new User();
            personne.age = 20;
            personne.email = "lofqsdfqfq@";
            personne.nom = "longuet";
            personne.prenom = "kevin";
            Assert.AreEqual(personne.isValid(), false);
        }

        [TestMethod]
        public void TestUserInfoNom()
        {
            User personne = new User();
            personne.age = 20;
            personne.email = "longuetk@gmail.com";
            personne.prenom = "kevin";
            Assert.AreEqual(personne.isValid(), false);
        }
        [TestMethod]
        public void TestUserInfoAllPrenom()
        {
            User personne = new User();
            personne.age = 20;
            personne.email = "longuetk@gmail.com";
            personne.nom = "longuet";
            Assert.AreEqual(personne.isValid(), false);
        }

        [TestMethod]
        public void TestProductGoodUser()
        {
            User maxime = new User();
            Product deo = new Product();
            deo.user = maxime;
            deo.nom = "deodorant axe";
            maxime.email = "maxime.aublet@gmail.com";
            maxime.nom = "Aublet";
            maxime.prenom = "Maxime";
            maxime.age = 21;
            Assert.AreEqual(deo.isValidProduct(), true);
        }

        [TestMethod]
        public void TestProductBadUser()
        {
            User maxime = new User();
            Product deo = new Product();
            deo.user = maxime;
            deo.nom = "deodorant axe";
            maxime.email = "maxime.aublet@gmail.com";
            maxime.prenom = "Maxime";
            maxime.age = 21;
            Assert.AreEqual(deo.isValidProduct(), false);
        }


    }

    [TestClass]
    public class testExchange
    {
        [TestMethod]
        public void testSaveTrue()
        {
            // On test si un save simple marche
          
            Exchange echangeMock = Mock.Of<Exchange>();
            Mock.Get(echangeMock).Setup(x => x.save()).Returns(true);
            Assert.AreEqual(true, echangeMock);
        }

        [TestMethod]
        public void testSaveFalse()
        {
            // On test si un retour false au save marche

            Exchange echangeMock2 = Mock.Of<Exchange>();
            Mock.Get(echangeMock2).Setup(x => x.save()).Returns(false);
            Assert.AreEqual(false, echangeMock2);
        }

        [TestMethod]
        public void testSaveMineur()
        {
            // On test si le save envoie bien un mail quand le User est mineur

            Exchange echangeMock = Mock.Of<Exchange>();
            Mock.Get(echangeMock).Setup(x => x.receiver.age).Returns(13);
            Assert.AreEqual(true, echangeMock);
        }

        [TestMethod]
        public void testSaveBadCo()
        {
            // On test si le save ne s'envoie pas dans la chaine de co est mauvaise

            Exchange echangeMock = Mock.Of<Exchange>();
            Mock.Get(echangeMock).Setup(x => x.connexBD).Returns(false);
            Assert.AreEqual(false, echangeMock);
        }

        [TestMethod]
        public void testSaveDateFalse()
        {
            // On test si le save ne s'envoie pas quand la date est supérieur à la date de début

            Exchange echangeMock = Mock.Of<Exchange>();
            Mock.Get(echangeMock).Setup(x => x.dateStart).Returns(2023/01/01);
            Assert.AreEqual(false, echangeMock);
        }

    }
}
