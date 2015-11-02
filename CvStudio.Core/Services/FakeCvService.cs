using CvStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Core.Services
{
    public class FakeCvService : ICvService
    {
        public Task<IEnumerable<Cv>> GetAllCvs()
        {
            var cvs = new List<Cv>()
            {
                new Cv()
                {
                    Id = 1,
                    Name = "Pedro",
                    Address = "Calle Mejico Nº 44",
                    Surname1 = "Lopez",
                    Surname2 = "Infante",
                    Birthday = new DateTime(1970,1,1),
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Title = "Fontanería",
                            Description = "Fontanero en prácticas",
                            StartDate = new DateTime(2013, 1, 1),
                            EndDate = new DateTime(2015, 2, 2),
                        },
                        new Experience()
                        {
                            Title = "Fontanería",
                            Description = "Fontanero senior",
                            StartDate = new DateTime(2015, 2, 2),
                        }
                    },
                    
                },
                new Cv()
                {
                    Id = 2,
                    Name = "Rosa",
                    Address = "Calle Granjilla Nº 6, Blq 5",
                    Surname1 = "Fajardo",
                    Surname2 = "Salado",
                    Birthday = new DateTime(1970,2,1),
                    PhotoUrl = "http://img02.deviantart.net/a501/i/2009/215/4/b/deviant_id_by_immortall_girl.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Title = "Pediodismo",
                            Description = "Redactora jefa en periódico digital",
                            StartDate = new DateTime(2000,3,5),
                        },
                    },
                    Awards = new List<Awards>()
                    {
                        new Awards()
                        {
                            Title = "Premio zapatilla de oro",
                            Description = "Premio por mi completa dedicación al periodismo de guerra",
                            AwardDate = new DateTime(2010,6,6),
                        }
                    },
                    Skills = new List<Skill>()
                    {
                        new Skill()
                        {
                            Description = "Redacción de panfletos de guerra",
                        }
                    }
                    
                },
            };

            return Task.FromResult<IEnumerable<Cv>>(cvs);
        }

        public Task<bool> AddCv(string cvLink)
        {
            return Task.FromResult(true);
        }

        public void Initialize()
        {
        }

        public void Reset()
        {
        }
    }
}
