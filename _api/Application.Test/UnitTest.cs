using System;
using System.Collections.Generic;
using Application.Entities;
using Application.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var repository = RepositoryFactory.GetLunchRepository();
            repository.CreateLunch(new Lunch()
            {
                Name = "Ajiaco",
                Description = "El ajiaco bogotano o santafereño consiste en una sopa de pollo que contiene diferentes tipos de papa y se puede servir sola o con crema de leche y alcaparras encurtidas, generalmente en tazones de barro cocido. El ajiaco también suele incluir mazorcas de maíz tierno. Por el importante rol cultural que juega, se le considera una tradición santafereña (por el nombre colonial de la ciudad, Santa Fe de Bogotá). El ajiaco típico bogotano tiene tres tipos de papa que le brindan cremosidad gracias a los diferentes niveles de cocción; el tipo de papa más importante es la criolla que es pequeña y de color amarillo vivo y se deshace dándole el color amarillo que lo caracteriza (los otros dos tipos de papa que incluye la receta son variedades regionales que se conocen localmente como papa pastusa y papa sabanera). El componente fundamental del ajiaco es una hierba llamada guasca que le da su sabor más característico. A diferencia de lo que sugiere su nombre, el ajiaco no es picante. El plato suele servirse acompañado de una tajada de aguacate. Se ha vuelto común servirlo acompañado de arroz blanco aunque ello es una adición que, a pesar de su popularidad, no es tradicional. Algunas preparaciones incluyen también arracacha, aunque tal práctica no concuerda del todo con la más pura tradición bogotana",
                Ingredients = "Pollo;papa criolla;papa sabanera;papa pastusa;guascas;alcaparras;mazorca de maíz tierno",
                Image = "https://cdn.colombia.com/sdi/2011/07/22/ajiaco-496022.jpg;https://www.deliciosi.com/images/1500/1510/ajiaco-de-pollo.jpg;http://elrancherito.com.co/wp-content/uploads/2017/07/Ajiaco.jpg"
            });
        }
    }
}
