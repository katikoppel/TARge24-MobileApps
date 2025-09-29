using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and " +
                "the smallest in the Solar System. It is a rocky planet " +
                "with a trace atmosphere and a surface gravity slightly higher " +
                "than that of Mars. The surface of Mercury is similar to Earth's Moon, " +
                "being heavily cratered, with an expansive rupes system generated from " +
                "thrust faults, and bright ray systems, formed by ejecta. " +
                "Its largest crater, Caloris Planitia, has a diameter of 1,550 km (960 mi), " +
                "which is about one-third the diameter of the planet (4,880 km or 3,030 mi).",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
                {
                    Name = "Venus",
                    Subtitle = "Earth’s twin planet",
                    HeroImage = "venus.png",
                    Description = "Venus is the second planet from the Sun. It is often called Earth's \"twin\" or \"sister\" among the planets" +
                    "of the Solar System for its orbit being the closest to Earth's, both being rocky planets," +
                    "and having the most similar and nearly equal size, mass, and surface gravity." +
                    "Venus, though, is significantly different, especially as it has no liquid water, and its atmosphere is far thicker" +
                    "and denser than that of any other rocky body in the Solar System. The atmosphere is composed mostly of carbon dioxide" +
                    "and has a thick cloud layer of sulfuric acid that spans the whole planet. At the mean surface level, the atmosphere reaches" +
                    "a temperature of 737 K (464 °C; 867 °F) and a pressure 92 times greater than Earth's at sea level," +
                    "turning the lowest layer of the atmosphere into a supercritical fluid." +
                    "From Earth, Venus is visible as a star-like point of light, appearing brighter than any other natural point of light in the sky," +
                    "and as an inferior planet always relatively close to the Sun, either as the brightest \"morning star\" or \"evening star\".",
                    AccentColorStart = Color.FromArgb("#a6393b"),
                    AccentColorEnd = Color.FromArgb("#d17f21"),
                    Images = new()
                    {
                        "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                    }
                },
                new()
                {
                    Name = "Earth",
                    Subtitle = "The ocean world",
                    HeroImage = "earth.png",
                    Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. " +
                    "This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. " +
                    "Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. " +
                    "The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere. " +
                    "Most of Earth's land is at least somewhat humid and covered by vegetation, while large ice sheets at Earth's polar deserts retain more water " +
                    "than Earth's groundwater, lakes, rivers, and atmospheric water combined. " +
                    "Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. " +
                    "Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation.",
                    AccentColorStart = Color.FromArgb("#2a6db1"),
                    AccentColorEnd = Color.FromArgb("#68a9dd"),
                    Images = new()
                    {
                        "https://solarsystem.nasa.gov/system/feature_items/images/17_earth.png",
                        "https://solarsystem.nasa.gov/system/feature_items/images/18_earth_carousel_2.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/19_earth_carousel_3.jpg"
                    }
                },
                new()
                    {
                        Name = "Mars",
                        Subtitle = "The Red Planet",
                        HeroImage = "mars.png",
                        Description = "Mars is the fourth planet from the Sun. It is also known as the \"Red Planet\", because of its orange-red appearance. " +
                        "Mars is a desert-like rocky planet with a tenuous atmosphere that is primarily carbon dioxide (CO2). " +
                        "At the average surface level the atmospheric pressure is a few thousandths of Earth’s, atmospheric temperature ranges from −153 to 20 °C (−243 to 68 °F) " +
                        "and cosmic radiation is high. Mars retains some water, in the ground as well as thinly in the atmosphere, forming cirrus clouds, fog, frost, " +
                        "larger polar regions of permafrost and ice caps (with seasonal CO2 snow), but no bodies of liquid surface water. " +
                        "Its surface gravity is roughly a third of Earth's or double that of the Moon. " +
                        "It is about half as wide as Earth or twice the Moon, with a diameter of 6,779 km (4,212 mi), and has a surface area the size of all the dry land of Earth.",
                        AccentColorStart = Color.FromArgb("#a23036"),
                        AccentColorEnd = Color.FromArgb("#eb3333"),
                        Images = new()
                        {
                            "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png/1280px-Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                            "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                            "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                        }
                    },
                new()
                    {
                        Name = "Jupiter",
                        Subtitle = "The giant planet",
                        HeroImage = "jupiter.png",
                        Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                        "It is a gas giant with a mass nearly 2.5 times that of all the other planets in the Solar System combined " +
                        "and slightly less than one-thousandth the mass of the Sun. " +
                        "Its diameter is 11 times that of Earth and a tenth that of the Sun. " +
                        "Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm), with an orbital period of 11.86 years. " +
                        "It is the third-brightest natural object in the Earth's night sky, after the Moon and Venus, " +
                        "and has been observed since prehistoric times. " +
                        "Its name derives from that of Jupiter, the chief deity of ancient Roman religion.",
                        AccentColorStart = Color.FromArgb("#9d4a40"),
                        AccentColorEnd = Color.FromArgb("#cd8026"),
                        Images = new()
                        {
                            "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                        }
                    },
                new()
                    {
                        Name = "Saturn",
                        Subtitle = "The ringed giant",
                        HeroImage = "saturn.png",
                        Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, after Jupiter. " +
                        "It is a gas giant, with an average radius of about 9 times that of Earth. " +
                        "It has an eighth of the average density of Earth, but is over 95 times more massive. " +
                        "Even though Saturn is almost as big as Jupiter, Saturn has less than a third of its mass. ",
                        AccentColorStart = Color.FromArgb("#996237"),
                        AccentColorEnd = Color.FromArgb("#c6502f"),
                        Images = new()
                        {
                            "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                        }
                    },
                new()
                    {
                        Name = "Uranus",
                        Subtitle = "The tilted ice giant",
                        HeroImage = "uranus.png",
                        Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
                        "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, " +
                        "which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure " +
                        "and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets. " +
                        "It has a marked axial tilt of 82.23° with a retrograde rotation period of 17 hours and 14 minutes. " +
                        "This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, " +
                        "followed by 42 years of continuous darkness.",
                        AccentColorStart = Color.FromArgb("#9d4a40"),
                        AccentColorEnd = Color.FromArgb("#996237"),
                        Images = new()
                        {
                            "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                        }
                    },
                new()
                    {
                        Name = "Neptune",
                        Subtitle = "The windy ice giant",
                        HeroImage = "neptune.png",
                        Description = "Neptune is the eighth and farthest known planet orbiting the Sun. " +
                        "It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, " +
                        "and the densest giant planet. It is 17 times the mass of Earth. " +
                        "Compared to Uranus, its neighbouring ice giant, Neptune is slightly smaller, but more massive and denser. " +
                        "Being composed primarily of gases and liquids, it has no well-defined solid surface. " +
                        "Neptune orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units " +
                        "(4.5 billion kilometres; 2.8 billion miles). " +
                        "It is named after the Roman god of the sea and has the astronomical symbol ♆, representing Neptune's trident.",
                        AccentColorStart = Color.FromArgb("#0c293d"),
                        AccentColorEnd = Color.FromArgb("#26abe0"),
                        Images = new()
                        {
                            "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                            "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                        }
                    }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
