using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DateMePlease.Entities;

namespace DateMePlease.Data
{
    public class DateMePleaseInitializer : DropCreateDatabaseIfModelChanges<DateMePleaseContext>
    {
        public DateMePleaseInitializer()
        {

        }

        protected override void Seed(DateMePleaseContext context)
        {
            if (context.Interests.Count() == 0)
            {
                try
                {
                    AddData(context);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    // todo log
                    ex.ToString();
                }
            }
        }

        private void AddData(DateMePleaseContext context)
        {
            var interestTypes = new List<InterestType>()
            {
                new InterestType()
        {
          Name = "Outdoors",
          Description = "Hiking, fishing, scuba diving, and more..."
        },
        new InterestType()
        {
          Name = "Fine Dining",
          Description = "I eat too."
        },
        new InterestType()
        {
          Name = "Sports",
          Description = "Go Sports Team!"
        },
        new InterestType()
        {
          Name = "Travel",
          Description = "Real travel people. Getting on a plane and everything."
        },
        new InterestType()
        {
          Name = "Movies",
          Description = "You'll need to know what movie this is from: 'I think we're going to need a bigger boat.'"
        },
        new InterestType()
        {
          Name = "Television",
          Description = "Sitting on the couch with Game of Thrones...what else?"
        },
        new InterestType()
        {
          Name = "Dancing",
          Description = "Clubbing and drinking.  Not ballet."
        },
            };

            context.InterestTypes.AddRange(interestTypes);
            context.SaveChanges();

            var members = new List<Member>()
            {
                new Member()
        {
          Username = "awkwardguy@yahoo.com",
          MemberName = "awkwardguy",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Crossfit family is very important to me I value art Oxford comma. Murakami Netflix working on my body and my mind Indian food feminism, home brewing I value art coffee home brewing amazing women I've met. Knowing the difference between their/there/they're my friends tell me they don't get why I'm single Myers-Briggs medical school The Daily Show snowboarding.
                            Dubstep medical school making people laugh my eyes. Bored at home having a few beers Werner Herzog using my farmshare thinking about trying yoga, my cats going to shows Ethiopian tattoos pickles. Murakami is pretty awesome I hate lists Kurosawa trying different restaurants fitness.",
            LookingFor = "Any Woman",
            Pitch = "If you are into books and historical dramas.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[0] },
              new Interest() { InterestType = interestTypes[3] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/awkwardguy.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Male",
              Birthdate = new DateTime(1990, 5, 17),
              CityTown = "Atlanta",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "disheveled@yahoo.com",
          MemberName = "disheveled",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Food trying different restaurants fixing my scooter I'm a good listener. I'm a big fan of feminism The Daily Show Sunday funday ask me anything, going to shows going back to school Sunday funday no drama shoot me a message. Discussing politics my eyes I don't take myself too seriously ask me anything going back to school strong and confident.
                             My beard coffee easy-going I'm really good at. Jazz cafes open-minded I'm pretty laid-back I'm a good listener medical school, I hate lists down to earth my goofy smile art school my dogs. I'm looking for I'm really good at working on my body and my mind Catcher in the Rye just looking to have some fun jazz cafes.",
            LookingFor = "Woman with similar interests",
            Pitch = "If you're not afraid of me, then you might be right for me.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[0] },
              new Interest() { InterestType = interestTypes[3] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/disheveled.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Gay",
              Gender = "Female",
              Birthdate = new DateTime(1990, 5, 17),
              CityTown = "Peachtree City",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "fashionnightmare@yahoo.com",
          MemberName = "fashionnightmare",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Pickles my dogs food I'm really good at. I hate lists honest and direct food trying this for the first time everything but country music, foodie someone who shares my sense of humor working at a coffee shop I know I listed more than 6 things Werner Herzog. Tacos sleeping late I enjoy bored at home whiskey joking around.
                            Amazing women I've met watching a movie using my farmshare thinking about trying yoga. Honest and direct coffee running shoes jazz cafes loyal, short-term dating loyal going to shows knowing the difference between their/there/they're short-term dating. My beard Arrested Development is pretty awesome hiking pickles exploring the city.",
            LookingFor = "Woman with a sense of style",
            Pitch = "How could you not love these glasses?",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[0] },
              new Interest() { InterestType = interestTypes[3] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/fashionnightmare.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Male",
              Birthdate = new DateTime(1988, 10, 30),
              CityTown = "Conyers",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "hairdowoman@yahoo.com",
          MemberName = "hairdowoman",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Quizzo my goofy smile beach days Myers-Briggs. It depends on the night listening to music down to earth trying different restaurants local sports teams, only looking for something casual Infinite Jest crossfit exploring the city art school. Bikes glass half-full someone who shares my sense of humor Catcher in the Rye playing my guitar Vampire Weekend.
                            I value art too many to list I don't really like talking about myself the simple things in life. Pickles Breaking Bad Werner Herzog happy hour Game of Thrones, long-term dating strong and confident skiing I hate lists fixing up my house. I enjoy foodie my favorite word is self-deprecating humor nothing too complicated optimistic.",
            LookingFor = "Woman with similar interests",
            Pitch = "Take a chance on a guy who can't seem to take a selfie in focus!",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[1] },
              new Interest() { InterestType = interestTypes[2] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/hairdowoman.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Gay",
              Gender = "Female",
              Birthdate = new DateTime(1987, 11, 23),
              CityTown = "Midtown Atlanta",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "intenselady@yahoo.com",
          MemberName = "intenselady",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Easy-going On The Road but then it wouldn't be private easy-going. Jazz cafes I'm not good at filling out these things fixing my scooter jazz cafes coffee, bacon I'm not good at filling out these things mountain biking only looking for something casual Myers-Briggs. Discussing politics the simple things in life nothing too complicated Myers-Briggs I'm just a regular guy everything but country music.
                            Working on my body and my mind knowing the difference between their/there/they're introvert playing my guitar. I'm a big fan of glass half-full my dogs just looking to have some fun fascinates me, my friends tell me they don't get why I'm single going back to school working on my body and my mind Kurosawa my eyes. I know I listed more than 6 things medical school Sunday funday medical school grilling it depends on the night.",
            LookingFor = "Man who can tolerate my vocal volume.",
            Pitch = "I am excitable, passionate, and I talk loudly.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[6] },
              new Interest() { InterestType = interestTypes[5] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/intenselady.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Female",
              Birthdate = new DateTime(1988, 2, 29),
              CityTown = "Stone Mountain",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "knifegirl@yahoo.com",
          MemberName = "knifegirl",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Introvert knowing the difference between their/there/they're as friends fixing my scooter. Sleeping late my goofy smile my eyes loyal whatever topic is on NPR, grilling someone who shares my sense of humor bored at home joking around everything but country music. Share a new experience as friends medical school fascinates me my goofy smile art school.
                            Sunday funday easy-going fixing my scooter chilling at a bar with friends. Playing my guitar happy hour joking around short-term dating On The Road, I don't take myself too seriously working at a coffee shop training for the marathon knowing the difference between their/there/they're skiing. My cats Indian food Indian food Infinite Jest foreign films Game of Thrones.",
            LookingFor = "Sharp dressed man or woman.",
            Pitch = "Take a stab at dating me.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[3] },
              new Interest() { InterestType = interestTypes[6] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/knifegirl.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Bisexual",
              Gender = "Female",
              Birthdate = new DateTime(1995, 8, 7),
              CityTown = "East Point",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "mustachioed@yahoo.com",
          MemberName = "mustachioed",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Recently moved back thinking about trying yoga using my farmshare Sunday funday. Myers-Briggs if you're down to actually meet at some point I'm really good at bikes Game of Thrones, activity partners discussing politics whatever topic is on NPR Ethiopian nothing too complicated. Vinyl records easy-going fitness but then it wouldn't be private I'm just a regular guy trying different restaurants.
                            Chilling at a bar with friends as friends food my height and shoulders. Running shoes Catcher in the Rye mountain biking trying different restaurants The Daily Show, grilling I'm looking for mountain biking Woody Allen my beard. Going to the gym Myers-Briggs Arrested Development running shoes going back to school mountain biking.",
            LookingFor = "Woman who likes facial hair.",
            Pitch = "Don't let the mustache fool you, I am definitely a hipster too.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[2] },
              new Interest() { InterestType = interestTypes[4] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/mustachioed.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Male",
              Birthdate = new DateTime(1981, 9, 19),
              CityTown = "Decatur",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "raspberryberet@yahoo.com",
          MemberName = "raspberryberet",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Rock climbing passionate about bored at home but then it wouldn't be private. I'm pretty laid-back Netflix thinking about trying yoga my friends tell me they don't get why I'm single I'm a big fan of, I love the smell of art school The Daily Show medical school shoot me a message. Amazing women I've met Portlandia crossfit listening to music extrovert foodie.
                            I don't take myself too seriously recently moved back I don't really like talking about myself Breaking Bad. Easy-going Doctor Who Myers-Briggs working at a coffee shop short-term dating, running shoes food Myers-Briggs really hoppy beers nothing too complicated. I'm a good listener going to shows my goofy smile my eyes The Daily Show trying this for the first time.",
            LookingFor = "A man...or not. I don't care.",
            Pitch = "Can't be full of drama.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[5] },
              new Interest() { InterestType = interestTypes[6] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/raspberryberet.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Female",
              Birthdate = new DateTime(1976, 11, 14),
              CityTown = "Marietta",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "smileydude@yahoo.com",
          MemberName = "smileydude",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"Recently moved back everything but country music foodie local sports teams. I enjoy Woody Allen my dogs making people laugh watching a movie, shoot me a message ask me anything Family Guy long-term dating going to the gym. I don't really like talking about myself going to shows vegetarian road trips road trips if you think we have something in common.
                             I have a crush on if you're down to actually meet at some point tacos home brewing. Parallel parking working on my body and my mind Vampire Weekend I don't really like talking about myself outdoor activities, pickles open-minded Vampire Weekend I'm not good at filling out these things adventures. New friends the simple things in life Infinite Jest I enjoy quizzo trying different restaurants.",
            LookingFor = "A woman who likes me.",
            Pitch = "Wait, I think I might look eager. Do I?",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[2] },
              new Interest() { InterestType = interestTypes[3] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/smileydude.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Male",
              Birthdate = new DateTime(1985, 8, 19),
              CityTown = "Dunwoody",
              StateProvince = "GA"
            }
          }
        },
        new Member()
        {
          Username = "smirkingviolet@yahoo.com",
          MemberName = "smirkingviolet",
          Created = DateTime.Today,
          LastLogin = DateTime.Today,
          Profile = new Profile()
          {
            Introduction = @"My cats no drama I hate lists my dogs. Everything but country music just looking to have some fun skiing everything but country music beach days, working on my body and my mind parallel parking running shoes you should message me new friends. If you're still reading this I'm a good listener Vampire Weekend bored at home Netflix listening to music.
                             Video games Kurosawa if you like my profile I'm not good at filling out these things. Outdoor activities crossfit self-deprecating humor Family Guy self-deprecating humor, The Daily Show fascinates me Sunday funday Family Guy nothing too complicated. Working at a coffee shop Breaking Bad tacos trying this for the first time vegetarian road trips.",
            LookingFor = "Woman with big eyes.",
            Pitch = "I am not this creepy in person. Really.",
            Interests = new List<Interest>()
            {
              new Interest() { InterestType = interestTypes[6] },
              new Interest() { InterestType = interestTypes[3] },
            },
            Photos = new List<Photo>()
            {
              new Photo() { Url = "/images/smirkingviolet.jpg", DateAdded = DateTime.Now, IsMain = true }
            },
            Demographics = new Demographics()
            {
              Orientation = "Straight",
              Gender = "Male",
              Birthdate = new DateTime(1991, 2, 14),
              CityTown = "Duluth",
              StateProvince = "GA"
            }
          }
        }
            };

            context.Members.AddRange(members);
        }
    }
}