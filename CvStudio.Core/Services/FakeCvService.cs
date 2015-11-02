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
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 2,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 3,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 4,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 5,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 6,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 6,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 6,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 6,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
                        }
                    }
                },
                new Cv()
                {
                    Id = 6,
                    Name = "Pepe",
                    PhotoUrl = "http://www.realtimearts.net/data/images/art/46/4640_profile_nilssonpolias.jpg",
                    Experiences = new List<Experience>()
                    {
                        new Experience()
                        {
                            Description = "fontanero en prácticas"
                        },
                        new Experience()
                        {
                            Description = "fontanero senior"
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
