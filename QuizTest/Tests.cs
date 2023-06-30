using Quizzify.IO;
using Quizzify.Externo;
using Quizzify.Facade;
using Quizzify.Excepcion;
using System.Security.Policy;
using System.Security.Principal;

namespace QuizTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestPuntaje1()
        {
            double expected = 5;

            var list = new List<PreguntaYRespuestaDTO>()
            {
                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "375ab9ca-27ff-45df-9300-1b7e52a97377",
                        Nombre = "Which element has the chemical symbol 'Fe'?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Gold", "Silver", "Tin" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Iron"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8be08877-4f72-407e-b76e-29fb5f714559",
                        Nombre = "What name is given to all baby marsupials?",
                        Correcta = "Joey",
                        Incorrectas = new List<string>() { "Calf", "Pup", "Cab" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Joey"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "03b95f64-dfe4-4c20-971a-605679740d4a",
                        Nombre = "How many planets make up our Solar System?",
                        Correcta = "8",
                        Incorrectas = new List<string>() { "7", "9", "6" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "8"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "cbb77d6c-2cdf-45e6-a071-8bcbb6f5be30",
                        Nombre = "What is the chemical makeup of water?",
                        Correcta = "H20",
                        Incorrectas = new List<string>() { "C12H6O2", "CO2", "H" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "H20"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "97950748-4f29-4c81-85fc-fb07c67cf74c",
                        Nombre = "How many bones are in the human body?",
                        Correcta = "206",
                        Incorrectas = new List<string>() { "203", "209", "200" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "206"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "1afe16d7-f5be-4963-a1cc-c5ee9d2471bf",
                        Nombre = "The element involved in making human blood red is which of the following?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Copper", "Iridium", "Cobalt" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Iron"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "4e24f27c-b02d-4966-8663-54b35b80e1f0",
                        Nombre = "An Astronomical Unit is the distance between Earth and the Moon.",
                        Correcta = "False",
                        Incorrectas = new List<string>() { "True" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "False"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8bcee933-ad65-4e32-9b54-230ec82a6c2f",
                        Nombre = "Not including false teeth; A human has two sets of teeth in their lifetime.",
                        Correcta = "True",
                        Incorrectas = new List<string>() { "False" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "True"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "728844cd-ec0d-4835-8d1b-073e022ddccd",
                        Nombre = "Which noble gas has the lowest atomic number?",
                        Correcta = "Helium",
                        Incorrectas = new List<string>() { "Neon", "Argon", "Krypton" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Helium"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "48293bf2-5bcf-4d41-85ec-4d4764a8be82",
                        Nombre = "What is the official name of the star located closest to the North Celestial Pole?",
                        Correcta = "Polaris",
                        Incorrectas = new List<string>() { "Eridanus", "Gamma Cephei", "Iota Cephei" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Polaris"
                },


            };

            double tiempo = 45.7;

            var logica = new LogicaOTDB();

            var actual = logica.CalcularPuntaje(list, tiempo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPuntaje2()
        {
            double expected = 3;

            var list = new List<PreguntaYRespuestaDTO>()
            {
                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "375ab9ca-27ff-45df-9300-1b7e52a97377",
                        Nombre = "Which element has the chemical symbol 'Fe'?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Gold", "Silver", "Tin" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Iron"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8be08877-4f72-407e-b76e-29fb5f714559",
                        Nombre = "What name is given to all baby marsupials?",
                        Correcta = "Joey",
                        Incorrectas = new List<string>() { "Calf", "Pup", "Cab" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Calf"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "03b95f64-dfe4-4c20-971a-605679740d4a",
                        Nombre = "How many planets make up our Solar System?",
                        Correcta = "8",
                        Incorrectas = new List<string>() { "7", "9", "6" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "9"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "cbb77d6c-2cdf-45e6-a071-8bcbb6f5be30",
                        Nombre = "What is the chemical makeup of water?",
                        Correcta = "H20",
                        Incorrectas = new List<string>() { "C12H6O2", "CO2", "H" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "H20"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "97950748-4f29-4c81-85fc-fb07c67cf74c",
                        Nombre = "How many bones are in the human body?",
                        Correcta = "206",
                        Incorrectas = new List<string>() { "203", "209", "200" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "206"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "1afe16d7-f5be-4963-a1cc-c5ee9d2471bf",
                        Nombre = "The element involved in making human blood red is which of the following?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Copper", "Iridium", "Cobalt" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Copper"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "4e24f27c-b02d-4966-8663-54b35b80e1f0",
                        Nombre = "An Astronomical Unit is the distance between Earth and the Moon.",
                        Correcta = "False",
                        Incorrectas = new List<string>() { "True" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "True"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8bcee933-ad65-4e32-9b54-230ec82a6c2f",
                        Nombre = "Not including false teeth; A human has two sets of teeth in their lifetime.",
                        Correcta = "True",
                        Incorrectas = new List<string>() { "False" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "True"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "728844cd-ec0d-4835-8d1b-073e022ddccd",
                        Nombre = "Which noble gas has the lowest atomic number?",
                        Correcta = "Helium",
                        Incorrectas = new List<string>() { "Neon", "Argon", "Krypton" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Helium"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "48293bf2-5bcf-4d41-85ec-4d4764a8be82",
                        Nombre = "What is the official name of the star located closest to the North Celestial Pole?",
                        Correcta = "Polaris",
                        Incorrectas = new List<string>() { "Eridanus", "Gamma Cephei", "Iota Cephei" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "easy", Factor = 1 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Polaris"
                },


            };

            double tiempo = 45.7;

            var logica = new LogicaOTDB();

            var actual = logica.CalcularPuntaje(list, tiempo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPuntaje3()
        {
            double expected = 0;

            var list = new List<PreguntaYRespuestaDTO>()
            {
                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "375ab9ca-27ff-45df-9300-1b7e52a97377",
                        Nombre = "Which element has the chemical symbol 'Fe'?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Gold", "Silver", "Tin" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Silver"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8be08877-4f72-407e-b76e-29fb5f714559",
                        Nombre = "What name is given to all baby marsupials?",
                        Correcta = "Joey",
                        Incorrectas = new List<string>() { "Calf", "Pup", "Cab" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Pup"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "03b95f64-dfe4-4c20-971a-605679740d4a",
                        Nombre = "How many planets make up our Solar System?",
                        Correcta = "8",
                        Incorrectas = new List<string>() { "7", "9", "6" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "7"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "cbb77d6c-2cdf-45e6-a071-8bcbb6f5be30",
                        Nombre = "What is the chemical makeup of water?",
                        Correcta = "H20",
                        Incorrectas = new List<string>() { "C12H6O2", "CO2", "H" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "H"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "97950748-4f29-4c81-85fc-fb07c67cf74c",
                        Nombre = "How many bones are in the human body?",
                        Correcta = "206",
                        Incorrectas = new List<string>() { "203", "209", "200" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "200"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "1afe16d7-f5be-4963-a1cc-c5ee9d2471bf",
                        Nombre = "The element involved in making human blood red is which of the following?",
                        Correcta = "Iron",
                        Incorrectas = new List<string>() { "Copper", "Iridium", "Cobalt" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Copper"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "4e24f27c-b02d-4966-8663-54b35b80e1f0",
                        Nombre = "An Astronomical Unit is the distance between Earth and the Moon.",
                        Correcta = "False",
                        Incorrectas = new List<string>() { "True" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "True"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "8bcee933-ad65-4e32-9b54-230ec82a6c2f",
                        Nombre = "Not including false teeth; A human has two sets of teeth in their lifetime.",
                        Correcta = "True",
                        Incorrectas = new List<string>() { "False" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "False"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "728844cd-ec0d-4835-8d1b-073e022ddccd",
                        Nombre = "Which noble gas has the lowest atomic number?",
                        Correcta = "Helium",
                        Incorrectas = new List<string>() { "Neon", "Argon", "Krypton" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Neon"
                },

                new PreguntaYRespuestaDTO
                {
                    Pregunta = new PreguntaDTO()
                    {
                        Id = "48293bf2-5bcf-4d41-85ec-4d4764a8be82",
                        Nombre = "What is the official name of the star located closest to the North Celestial Pole?",
                        Correcta = "Polaris",
                        Incorrectas = new List<string>() { "Eridanus", "Gamma Cephei", "Iota Cephei" },
                        Categoria = new CategoriaDTO() { Id = "ceffd320-2540-40f1-b161-fe94091fe9cd", Nombre = "Science & Nature" },
                        Dificultad = new DificultadDTO() { Id = "5395a72b-65f2-4a64-b4f1-bedc72ab600d", Nombre = "medium", Factor = 3 },
                        Origen = new OrigenDTO() { Id = "234ig604-hh32-3557-7e9e-22e8af5d7zzc", Nombre = "otdb" }
                    },
                    Respuesta = "Gamma Cephei"
                },


            };

            double tiempo = 65.2;

            var logica = new LogicaOTDB();

            var actual = logica.CalcularPuntaje(list, tiempo);

            Assert.AreEqual(expected, actual);
        }

        
    }
}