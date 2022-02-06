using AnalizadorLex1;
using System;
using Xunit;

namespace AnalizadorLexicoTest
{
    public class UnitTest1
    {
        [Fact]
        public void ValidandoEmail1()
        {
            var r = LexicalAnalyzer.IsValidEmail("20155973@ce.pucmm.edu.do");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoEmail2()
        {
            var r = LexicalAnalyzer.IsValidEmail("enmanuelcruzdejesus@gmail.com");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoEmail3()
        {
            var r = LexicalAnalyzer.IsValidEmail("enmanuel@prueba.com");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoEmail4()
        {
            var r = LexicalAnalyzer.IsValidEmail("enmanuel@.com");
            Assert.Equal(false, r);

        }




        [Fact]
        public void ValidandoMatricula1()
        {
            var r = LexicalAnalyzer.IsValidId("2015-5973");
            Assert.Equal(true, r);

        }
        [Fact]
        public void ValidandoMatricula2()
        {
            var r = LexicalAnalyzer.IsValidId("2020-0001");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoMatricula3()
        {
            var r = LexicalAnalyzer.IsValidId("1999-0001");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoMatricula4()
        {
            var r = LexicalAnalyzer.IsValidId("20200001");
            Assert.Equal(false, r);

        }


        [Fact]
        public void ValidandoMateria()
        {
            var r = LexicalAnalyzer.IsValidsig("CSD-1730-4988-ISC-314");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoMateria2()
        {
            var r = LexicalAnalyzer.IsValidsig("CSD-1730-4988-ISC-001");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoMateria3()
        {
            var r = LexicalAnalyzer.IsValidsig("CSD-1730-4988-ISC-111");
            Assert.Equal(true, r);

        }


        [Fact]
        public void ValidandoMateria4()
        {
            var r = LexicalAnalyzer.IsValidsig("CSD-1730-4988");
            Assert.Equal(false, r);

        }


        [Fact]
        public void ValidandoTelefono1()
        {
            var r = LexicalAnalyzer.IsValidPhone("809-876-0987");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoTelefono2()
        {
            var r = LexicalAnalyzer.IsValidPhone("849-111-1111");
            Assert.Equal(true, r);

        }


        [Fact]
        public void ValidandoTelefono3()
        {
            var r = LexicalAnalyzer.IsValidPhone("800-222-2222");
            Assert.Equal(true, r);

        }


        [Fact]
        public void ValidandoTelefono4()
        {
            var r = LexicalAnalyzer.IsValidPhone("a800-222-2222");
            Assert.Equal(false, r);

        }

        [Fact]
        public void ValidandoURL()
        {
            var r = LexicalAnalyzer.IsValidURL("https://www.xunit.net/docs/getting-started/netfx/visual-studio");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoURL2()
        {
            var r = LexicalAnalyzer.IsValidURL("https://www.h-schmidt.net/FloatConverter/IEEE754.html");
            Assert.Equal(true, r);

        }

        [Fact]
        public void ValidandoURL3()
        {
            var r = LexicalAnalyzer.IsValidURL("https://www.datacamp.com/community/tutorials/text-analytics-beginners-nltk?utm_source=adwords_ppc&utm_campaignid=1455363063&utm_adgroupid=65083631748&utm_device=c&utm_keyword=&utm_matchtype=b&utm_network=g&utm_adpostion=&utm_creative=332602034358&utm_targetid=aud-299261629574:dsa-429603003980&utm_loc_interest_ms=&utm_loc_physical_ms=9069760&gclid=Cj0KCQjw-LOEBhDCARIsABrC0TmTeVwvGvrPgXdMAQC4Ac7bja7ZwmJkbKPIWQqbPGA2GMFacpGiT-0aArhkEALw_wcB");
            Assert.Equal(true, r);

        }


        [Fact]
        public void ValidandoURL4()
        {
            var r = LexicalAnalyzer.IsValidURL("http:\\a.com");
            Assert.Equal(false, r);

        }

    }
}
