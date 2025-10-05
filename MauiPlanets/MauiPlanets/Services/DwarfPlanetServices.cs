using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    internal class DwarfPlanetsServices
    {
        private static List<DwarfPlanet> dwarfPlanets = new()
        {
            new()
            {
                Name = "Pluto",
                Subtitle = "The classic dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt," +
                " a ring of bodies beyond the orbit of Neptune." +
                " It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun." +
                " It is the largest known trans-Neptunian object by volume by a small margin," +
                " but is less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock" +
                " and is much smaller than the inner planets. Pluto has roughly one-sixth the mass of the Moon and one-third of its volume." +
                " Originally considered a planet, its classification was changed when astronomers adopted a new definition of planet.",
                AccentColorStart = Color.FromArgb("#2f3b4d"),
                AccentColorEnd   = Color.FromArgb("#8aa1b1"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/05/pia19968-charonmoon-jpg.webp",
                    "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/dwarf-planets.jpg?resize=1200,675"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "Asteroid belt dwarf planet",
                HeroImage = "ceres.png",
                Description = "Ceres (minor-planet designation: 1 Ceres) is a dwarf planet in the main asteroid belt" +
                " between the orbits of Mars and Jupiter. It was the first known asteroid," +
                " discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily," +
                " and announced as a new planet. Ceres was later classified as an asteroid and more recently as a dwarf planet," +
                " the only one not beyond the orbit of Neptune and the largest that does not have a moon.",
                AccentColorStart = Color.FromArgb("#1a1a1a"),
                AccentColorEnd   = Color.FromArgb("#737373"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/2948/Image_of_Ceres_with_bright_spot.jpeg?w=640&h=350&fit=clip&crop=faces%2Cfocalpoint",
                    "https://science.nasa.gov/wp-content/uploads/2024/03/ceres-dawn-pia19562-16x9-1.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/dwarf-planets.jpg?resize=1200,675"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "Elongated Kuiper belt dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation: 136108 Haumea) is a dwarf planet located beyond Neptune's orbit." +
                " It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory," +
                " and formally announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in Spain," +
                " who had discovered it that year in precovery images taken by the team in 2003." +
                " From that announcement, it received the provisional designation 2003 EL61.",
                AccentColorStart = Color.FromArgb("#3e3e3e"),
                AccentColorEnd   = Color.FromArgb("#6a7b8c"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/h/haumea_th.jpg?w=320&h=240&fit=clip&crop=faces%2Cfocalpoint",
                    "https://static.wikia.nocookie.net/expanse/images/2/24/Haumea%2BMoons_by_NASA.jpg/revision/latest?cb=20200206145229",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/dwarf-planets.jpg?resize=1200,675"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "Methane-ice covered dwarf planet",
                HeroImage = "makemake.png",
                Description = "Makemake (minor-planet designation: 136472 Makemake) is a dwarf planet" +
                " and the largest of what is known as the classical population of Kuiper belt objects," +
                " with a diameter approximately that of Saturn's moon Iapetus, or 60% that of Pluto." +
                " It has one known satellite. Its extremely low average temperature, about 40 K (−230 °C)," +
                " means its surface is covered with methane, ethane, and possibly nitrogen ices." +
                " Makemake shows signs of geothermal activity and thus may be capable of supporting active geology and harboring an active subsurface ocean.",
                AccentColorStart = Color.FromArgb("#2c2c4c"),
                AccentColorEnd   = Color.FromArgb("#50507a"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/m/makemake_th.jpg?w=320&h=240&fit=clip&crop=faces%2Cfocalpoint",
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/5067/Makemake_moon-1.jpeg?w=800&h=600&fit=clip&crop=faces%2Cfocalpoint",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/dwarf-planets.jpg?resize=1200,675"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Massive scattered disk dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris (minor-planet designation: 136199 Eris) is the most massive and second-largest known dwarf planet in the Solar System." +
                " It is a trans-Neptunian object (TNO) in the scattered disk and has a high-eccentricity orbit." +
                " Eris was discovered in January 2005 by a Palomar Observatory–based team led by Mike Brown and verified later that year." +
                " It was named in September 2006 after the Greco–Roman goddess of strife and discord." +
                " Eris is the ninth-most massive known object orbiting the Sun and" +
                " the sixteenth-most massive in the Solar System (counting moons)." +
                " It is also the largest known object in the Solar System that has not been visited by a spacecraft.",
                AccentColorStart = Color.FromArgb("#1a1a1a"),
                AccentColorEnd   = Color.FromArgb("#737373"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/e/eris_th.jpg?w=320&h=240&fit=clip&crop=faces%2Cfocalpoint",
                    "https://www.scienceabc.com/wp-content/uploads/2020/01/Eris-dwarf-planet-in-the-outer-spaceLarichs.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/dwarf-planets.jpg?resize=1200,675"
                }
            }
        };

        public static List<DwarfPlanet> GetAllDwarfPlanets()
            => dwarfPlanets;
    }
}
