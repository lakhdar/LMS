﻿

namespace Infrastructure.Data.BoundedContext.UnitOfWork
{

    using Domain.BoundedContext.BlogingModule;
    using Domain.BoundedContext.ElearningModule;
    using Domain.BoundedContext.ERPModule;
    using Domain.BoundedContext.MembershipModule;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class InitialMemorySet
    {
        private List<Customer> _customers;
        private List<Address> _addresses;
        private List<Department> _departments;
        private List<Organization> _organizations;
        private List<Position> _positions;
        private List<User> _users;
        private List<Role> _roles;
        private List<Claim> _claims;
        private List<Login> _logins;
        private List<News> _news;
        private List<Event> _events;
        private List<Course> _courses;



        public List<Customer> Customers
        {
            get
            {
                if (this._customers == null)
                {
                    this._customers = new List<Customer>()
                    {
                    new Customer(){
                       Id = new Guid("0c11fc14-c881-c335-e1e8-08d1b45385cd"),
                    Name = "Alfreds Futterkiste",
                    Address = this.Addresses[0],
                    Phone = "030-0074321",
                    Email = "toto@toto.com",
                    Organizations =this.Organizations.Skip(0).Take(1).ToList()
                    },
                     new Customer(){
                       Id = Guid.NewGuid(),
                    Name = "ANATR",
                    Address = this.Addresses[1],
                    Phone = "(5) 555-4729",
                    Email = "toto@toto.com",
                     Organizations =this.Organizations.Skip(1).Take(1).ToList()
                    },
                    new Customer(){
                       Id = Guid.NewGuid(),
                    Name = "AROUT",
                    Address = this.Addresses[2],
                    Phone = "(171) 555-7788",
                    Email = "totoz@toto.com",
                     Organizations =this.Organizations.Skip(2).Take(1).ToList()
                    },

                     new Customer(){
                       Id = Guid.NewGuid(),
                    Name = "BERGS",
                    Address = this.Addresses[3],
                    Phone = "0921-12 34 65",
                    Email = "totocc@toto.com",
                     Organizations =this.Organizations.Skip(3).Take(1).ToList()
                    },
                     new Customer(){
                       Id = Guid.NewGuid(),
                    Name = "BLONP",
                    Address = this.Addresses[4],
                    Phone = "88.60.15.31",
                    Email = "totocc12@toto.com",
                     Organizations =this.Organizations.Skip(4).Take(1).ToList()
                    },
                     new Customer(){
                       Id = Guid.NewGuid(),
                    Name = "Hungry Coyote Import Store",
                    Address = this.Addresses[4],
                    Phone = "(503) 555-6874",
                    Email = "totocxxc12@toto.com",
                     Organizations =this.Organizations.Skip(5).Take(1).ToList()
                    } 

                    };
                }
                return this._customers;
            }
        }

        public List<Address> Addresses
        {
            get
            {
                if (this._addresses == null)
                {
                    this._addresses = new List<Address>()
                    {
                        new Address()
                        {
                            Id = new Guid("515500a9-5a65-c388-daa6-08d1b453fc17"),
                            AddressLine1 = "Obere Str. 57",
                            City = "Berlin",
                            ZipCode = "12209"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "Avda. de la Constitución 2222",
                            City = "México D.F.",
                            ZipCode = "05021"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "120 Hanover Sq.",
                            City = "London",
                            ZipCode = "WA1 1DP"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "24, place Kléber",
                            City = "Strasbourg",
                            ZipCode = "67000"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "City Center Plaza 516 Main St.",
                            City = "Elgin",
                            ZipCode = "97827"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "507 - 20th Ave. E.\\r\\nApt. 2A WA",
                            City = "Seattle",
                            ZipCode = "98122"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "908 W. Capital Way WA",
                            City = "Tacoma",
                            ZipCode = "98401"
                        },
                         new Address()
                        {
                            Id =  Guid.NewGuid(),
                            AddressLine1 = "Edgeham Hollow Winchester Way",
                            City = "London",
                            ZipCode = "98401"
                        }

                    };
                }
                return this._addresses;
            }
        }

        public List<Department> Departments
        {
            get
            {
                if (this._departments == null)
                {
                    this._departments = new List<Department>()
                    {
                        new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test",
                            Positions = new List<Position>(this.Positions)
                        },
                        new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test1",
                            Positions = new List<Position>(this.Positions)
                        },
                         new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test2",
                            Positions = new List<Position>(this.Positions)
                        },
                         new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test3",
                            Positions = new List<Position>(this.Positions)
                        },
                         new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test4",
                            Positions = new List<Position>(this.Positions)
                        },
                         new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test5",
                            Positions = new List<Position>(this.Positions)
                        },
                         new Department()
                        {
                            Id = Guid.NewGuid(),
                            Name = "test6",
                            Positions = new List<Position>(this.Positions)
                        },
                    };

                }
                return this._departments;
            }
        }


        public List<Organization> Organizations
        {
            get
            {
                if (this._organizations == null)
                {
                    this._organizations = new List<Organization>()
                    {
                       new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Siege",
                            Departments =this.Departments.Skip(0).Take(1).ToList(),
                            Address=this.Addresses[0]
                        },
                         new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Siege2",
                            Departments =this.Departments.Skip(1).Take(1).ToList(),
                            Address=this.Addresses[1]
                        },
                         new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Siege3",
                            Departments =this.Departments.Skip(2).Take(1).ToList(),
                            Address=this.Addresses[2]
                        },
                         new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Sieg4e",
                            Departments =this.Departments.Skip(3).Take(1).ToList(),
                            Address=this.Addresses[3]
                        },
                         new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Siege5",
                            Departments =this.Departments.Skip(4).Take(1).ToList(),
                            Address=this.Addresses[4]
                        },
                         new Organization()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Siege6",
                            Departments =this.Departments.Skip(5).Take(1).ToList(),
                            Address=this.Addresses[5]
                        },
                    };


                }
                return this._organizations;
            }
        }

        public List<Position> Positions
        {
            get
            {
                if (this._positions == null)
                {
                    this._positions = new List<Position>()
                    {
                        new Position()
                        {
                            Id = new Guid("5a0971d4-3205-ce80-fa51-08d1b453d5ac"),
                            Title = "Sales Representative",
                        },
                         new Position()
                        {
                            Id = Guid.NewGuid(),
                            Title = "Owner",
                        },
                        new Position()
                        {
                            Id = new Guid("ba9fdac0-6fdb-c65c-73fa-08d1c048b23e"),
                            Title = "Order Administrator",
                        },
                         new Position()
                         {
                            Id = new Guid("ff9b26b1-8c8c-c649-318e-08d1e2d77734"),
                            Title = "Order Administrator",
                        },
                    };
                }

                return this._positions;
            }
        }

        public List<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = new List<User>()
                    {
                        new User()
                        {
                            Id = new Guid("448e47ad-0fc3-c5c2-584d-08d1b874916a"),
                            UserName = "aaaa@aaa.com",
                            PasswordHash = "ADlfX1+zP7nNsHgdei/CbMQHM6g0fIYu2YAlrqIA6ULALmWBIDHebhWYLo8f//P4+g==",
                            TitleOfCourtesy = Civility.Ms,
                            Gender = Gender.Female,
                            PhoneNumber = "206) 555-9857",
                            LastName = "Davolio",
                            FirstName = "Nancy",
                            BirthDate = DateTime.ParseExact("12/08/1948", "M/d/yyyy", (IFormatProvider)CultureInfo.InvariantCulture),
                            Email = "aaaa@aaa.com",
                            Photo = new UTF8Encoding().GetBytes("FRwvAAIAAAANAA4AFAAhAP////9CaXRtYXAgSW1hZ2UAUGFpbnQuUGljdHVyZQABBQAAAgAAAAcAAABQQnJ1c2gAAAAAAAAAAAAgVAAAQk0gVAAAAAAAAHYAAAAoAAAAwAAAAN8AAAABAAQAAAAAAKBTAADODgAA2A4AAAAAAAAAAAAAAAAAAAAAgAAAgAAAAICAAIAAAACAAIAAgIAAAMDAwACAgIAAAAD/AAD/AAAA//8A/wAAAP8A/wD//wAA////AP8MsMkACwkJAAAKAJAJAAAAAAkJoJqQCwkACpCgAAAAD//v///////////LnPz++v/////t//7e/97+/P//2toA2QAAkAkAkAAAAAAJCgAJC8AACQCQAAAACgCsoODg4PDpypAAqcsMAACQkOAAAAkJCwAA0AkAkAAACQAAmgAP///////+//////yt69vf39//////7+3//v////78rwyaCg0AAJoAAAAAAAAACQkKAAsAmpAACQAAkAwJAJAJAPqQraAAkLALAAAAAJAACQAAAJAJqbAJAJoAAAAAwAC//////v///////8+fvL77/+v////+/f/+/f/P/v/5vAsAkJAAkAAJAAAAAAAAkAAAkJAJoMCwAACwAAmgDg4ODvytoMkAAMsAkAAAmpoJoACwCQCQkA0AqQkACQkKAAD////+//7///////Dw/9/trf3//////v797+/8/e/sDwyawAoAoJAAAACQAAAACQqQCgAAkJAACgAADKAMCQCQkPkA2gCakADaANAAAAnAkAAAkLAAqamwkAAAAKwAAAv/7///////////7anfD/n////w//////3+/97/79/5qaAJCQkAkACQAAAAAAAJCpAAkJqQAKkNCQAAqQALDgysoPrpqcoACpmpCwAAAJCwAJCQAAkAkNAACakAAJAAAJ/////////v///+2t68/e/9ra3//////+/vy+/e2+/K0NDgCgAAAJAAAAAAAACQCQCQAAAACQAKAACQAAAAAJqQDfCQypAJCQ6QkAsACQqQCQAAkLAJoJqQkJAACQsACf///////v/////9CenPv78P///v/e/////9/9/r/v2pCwqQkAqQCQAAAAAAAAAAAAAAkJAAkKkJAAoAAKywCwwOCvDwvAkAAAmtqQkAAAkPAACQCQkAmQmpoJAAAAAAAP/+///v/+/+///qnp+/3t//3//f///P///v7+38/e/AANAACQAAAAAAAAAAAAAAkAkACgCQCQAAsAkAAJAAwAoJwP8PC8oLCgAJDwqakACQsJAJAAkAALDQkKkAAJoAC//////////////Q+enw++8Pr8v+/9//////3/r/r577wKnAoAkJAAkAAAAAAJAAAAAAkAAAAAsAAAAKAAAAsMkKAPCw8AnAAJAAsAnAALAK0ACwCZqQmpCwCZAAAAnAD////+//7/7///ypDw/P/f3/3//f2+//3///78/P3+/ACQCpAAAAoJAAAAAAAAAACwAJAJAAAJAJCayQAAqQAKDAnPAPANoAkAAJCfC5CcAJmgkAmgAAAJCQmgCQAJoJ//////////3//umc8P2+nvr8vp777//ev9v////w/t8KkK0ACQCQkAAAAAAAAAAAkAkAAAAAAACaAJAAkAANoJAKCvra2wCayQAAAAkACpAJrQAJAJCQm8sJyZAAkACa//////7//v7+/9rLD9rf+9+f/f39/f///+///+/PD77Q6QCcAAAAAAAAAAAAAAAAAAAACQAAAAAAmgAAAJCwwA6cAP2pDprJoKkKkKmpCa0Am5AK0KkACQkLCpAAAJC9/////////////AmtCw8L7a/p76++v9r9//2//////P/pAJoLAAAAkKkAAAAAAAAAkAkAAAAAAAkACbAAAAAAsAAK0PreuekADQAJAJDQsJmpoPCQCQCQkLCQmQAAAACe///////v//z/wPDa/Pn9n9+f+f39/v//79/t///vz/7engkAAJAAAJAAAAAAAAAAAAAJAJAAAAAJnACQAADwAAkAAP263K2pAKkAAACwCcqcCZoAsAkKnpALAKAAkAn7/////v//7+/8CwmtCa3r7+nvD8vvn73//////////+/wAJAAkAAJAAAAAAAAAAAJAJAAAACQCQCaCpAAAAkAAArKCvrtq/mtqQDanJCempmpyamZCQCQCQmQmQAAAAC8//////7//f/LwPDantv9+f+d+/+f7f/r3/7b///+///sCaywAAAACQkAAAAAAAAAAACQCQAAAJAAkAAAkACgAAAA0P2+2s+8vLoJoKAJCaybqZ4KmpAJCwC8qQAAAACb/////////v8AkJ6cue2vzw/rzw/p+8/f+///z///////4JAJAAAAoAAAAAAAAAAAAAAAAAAAAACaCQkAAJCQAAAAC//p/byem8kAkJkAsJsNmgmZwACQkJoJCQAAkAkP///+///v//yQqQCw2tvfv/29uf2/z/v/7f2/+//////+kAsMAJCQkAkAAAAAAAAAAJAAAAkAAArQkKAAmgAAAJCaCfn/6+vr2tutC8oJwLywvJsAqQkLDwmQsAAAAAC5///////978oMnK0Nrb6+2tvtr8v8vbz9/+/8/f/////tAACakAAAAJAAAAAAAAAAAAAAAAAAAJAAAJCQAADwkAAA2v6tv9vfD60KkJCwsAkLC9C5kAAAkAAJAAAAkAkP/////v/v/9CaAJCw8P35/+2/37y///+v+//7+///////4JAAAAAAkAAAAAAAAAAAAAAAAAAAAAkAkAAAkJAAAAqamvna2vy/vL+fCw8JC5qckLkOkJCQuQmwkAAAAACQv/7/////7+AJCa0Ly9r+n9vL6f/a2v35/f3/z5//////wAAJCQkACwCQAAAAAAAACQAAAJAACaAJqQAAAAsJ4JAMkP6trfvw29rwvAkPkAALCw25CwAJAAAJCwAAAAAJ///////v/wkMCsmtva/b/r7/3/D//9v/7/v//+/////+sAAACgAAAAAAAAAAAAAAAAAAAAAAsJAAAAkAmpAAAACQqfDfrw/p6+vb6bCwvAkL0JqakAmpAJCwAAAACQCb////7//9/AAKkJD5772+2/35/p/72+//2/z/n5/////9AAAACQAJCQAAAAAAAAAAAAAAAAAJwAAKkJoAAACQCaAKnP6g0P2/vJytvwkNCwCZCwm56QCQsAkJCQAAAAAAD+/////v7wAJDa8Pnt7b/Pv+n/rf79/L/////vn////+kAAJAAAAAAkAAAAAAAAAAAAAAAkLAAAJAAAAsPCgAA8NC/3/r6/tv7+envC6mtoKnJrQmgkACQAAAAAAAAAJvf///+///gkAqQnw+/v9v97//9/737//6f29+f7/////wJAAAJAAAAAAAAAAAAAAAAAAAADwAACQmpCQCQkJrQAAAPvv3/2/6empub0J25DQmwkLkJAJAAsJCQAAAJCQD//v////7QANDLy9re3v//+f2v+f/t+f3+/v//n5///5sAAAAACQCQAAAAAAAAAAAAAAAAsJAAkACQAAnwrAAACgvPzwvtr/n5rfD/qasAsJ6amp6QCQkAkAAAAAAAAA++/////t8AkAmw8P37+/y9/+/97+37/++/n73w/+///+AAAAAAAAAAAAAAAAAAAAAAAACfAAAAAJvKkAsAkJoK0NCfqeya+e8K260L35yfCwkJCZmpAKCQAACQAAAAAJCf///+/+/ACw4Pn/r9/f//r9v/vfvfz5/P/fv/vb///9mgAAsAAAAJAAAAAAAAAAAAALywsAAAmgCQAJ6eAACQCgoP/L/tr5v9rbvwsLsJnanwvLDQAJAJCQAAAAAACQsN//7///8AAJnw8P36/r3/3//P///r//+968+fy9rf/60AAAAAAAAAAAAAAAAAAAAAAAkNAACQCQsAnwkJCwDAkNCf6/y62+8L2tqf28n6C5AJAJmpCQAKAAAAkAAAAACa/t///vwJCQ6fn769//+////73p/98PD/vfvvv/2///CQAAAAAAAAAAAAAAAAAAAAC5qaAAkAkJAPoLygAAsLDgoPDwvt/vm8ra36mpqQmembC5qQAAkAkAAAAAAAAAmt///e/9oADwva/P3/+f/P/p////+ev9/63r/by8vp7wmgAAnAAAAAAAAAAAAAAAAAkMCQCQCpALD5CQAJANAAwJDfrP7a+fnr25qb29vbC5qQmQ0LCQCQAJAAAAAAAJCa3v7//vAJAJ8Pn7/L/v//n/+fz57/2vD9v9D9vb2fn/AJAAoAAAAAAAAAAAAAAAAAsJDpAJCQucmgDgkMAKAAsMsP2w8PD76cvPntqamtvLmtoLCQmpAAkAAAkAAAAAAJv9////wAmsva/ev/372//97/v/n6/f8Pnr++/vra2+kAAJAAAAAAAAAAAAAAAAAAmgkAAAkLCr0JCQCwqQDwyw6fDtr56em7y56729vbCa0JmQkAkACQAAAAAAAAAACaD//v7wAADby9+/3w+97//7/97f79+trf6fy9vZ+9C9CwAAywAAAAAAAAAAAAAAAJyQqQCpC8nQCgALAAnAsJrAkPC5ra2/C8u8udrampC9qbCpoJoAkACQAACQAAAAkJ2+///eCQ2w+/vt6////9rf37+/vfrb/628va2++QvQCQAJAAAAAAAAAAAAAAAACaAAkAmZqQsKCQuckPALwKwLDvsMCa2p/b/Lnrub29uQuQmckAmQCQAAAAAJAAAAAArf7f7wAAqfD8/b39/f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oA8ACakLCgsAAAAAAAAAAAAAAAAAAAAAAAAJCQkLCamtC9rfn/////Cp+p8Py9rb6fvp6amfCQubwLCakAkJAAAJCQAAAAAAAACQsK2/v//////9/+3/2968va0J4JwAkACaAAAMkMAAAAAAAAAAAAAAAAAAAAAJoJAACgCQmp8LvL2v/9////CfCenpva+/nw+bm9rwmpAAmQAJAJAAAJCQAAAAAAAAAAAACdvf/////////5+frb3fD5rakOmpDLAMmtqQAJCQAAAAAAAAAAkAAAAAAJCQAACQkJC8kPDw2fqfvb///7Cenpqb+vn57b+tramZqckLmgmwCaAACQAAkAAAAAAAAAkJn7///////////f/v3/6w/a2QnpAMqQCQAAAAqaAAAAAAAAAAAAAAAAAAkAAACQAKAAsAranpq+n9++/f/fAL8L2sn5+/u8vbm5y8kLCQAJAJCQCQAAkJAAAAAAAAAAAOv/////////////n5+tvfmtrPCa2pAJ4LCQkJwAkKAAAAAAAAAAAAAAAAAKkJAJCQkNCQmtsL3pr7ntv///AAvan7y+28+/mvywuakJsJCQkLAJAACQAAkAAAAAAAAACZ+f//////////////3/y96fmw8JCcvAkMvKDgkArQkAAAAAAAAJAAAAAACQAAAAAAALALyw+Qvb2t6w6fy+AAmtravbv7n5/bn5C9C8CQ8ACQkKkAAAkLAAAAAAAAAAu///////////3//fz569va3w/NmtraCbypAJCQoJAAAAAAAAAAAAAAAAAAAAAJAJCQsACQkPAPmt6akPnr/rAJrb2tn63w8Pqbyw+QuQmwkJmpAJAACQAAAAAAAAAAAL3//////////////7+/3a3tsP2wrQmsmsCQy8kACcALAAAAAAAAAAAAAACQkAkAAAoACQkAvLC7DwsPDw/vwPAACgvb6f+/n5+tvZCwkLAJCwCQqQCQALCQAAAAAAAACb///////////////f39r/n7zwvL2a0LyQvKkAoPAKkAAAAAAAAAAAAAAAAAAACQCQkLAAoJC5ycsPDwmrD9v+kLyQC9vp/a8Lnwu+mfDQkLAJCQkJAACQAJAAAAAAAAn/v////////////9///L2f6fvfD8vprQvLCdDw0AkAAJAAAAAAAAAJAAAJAAAAAAAJAAkJwLDasLzwsLycsK2rDAsKnp6fv7296fnJvpsLCQkKkLCakAAAkAAAAAAAAJ+9////////////////2//vnw+p+byQ2pyw2goJoLypygCQAAAAAAAAAAAACQAJAAmgqQAAkAmpy8ucvAsLD9rfALwNvL+9r56wubC/CZAJCQCZAJCQAAkJAAAAAAAACb///////////////f+ev8n57fCfy8mtqcsNqemeDQCQCcoAAAAAAAAAAACQAAAAAJAAkAALALy8sPnqkLDp6amvAACwCw2v3/n9vp+QvKmanJoAkAkAkAAACQAAAAAAn//////////////////9+f8Pmp3gmtrbyfDa0JygmtrLAAkAAAAAAAAAAAAAAACQAACQAAkACQkPCQ6ZDw+bDw8PAJwLyan7+/++nwv5uZoNCwkJqQCwCQCQAAAAAAAAm9v///////////////D/np+e3auekLkOmgsJranJ6QkMmgAAAAAAAAAAAAAAAAAACwCpAACQALCw6bysqfDg8LC7AAqQoJ6cvfD5+b0PDa2QsJAAkJAJAAAAkAAAAAAL///////////////////56/D5q9Dw8MD5y9Da2p6anLy5rQ2pAAAAAAAAAAkAAAAAkAkACQCgmg0L0KnbngufC8kPCgnLDanr+vvb+vCwmpsLCakJCQCQAAAJAAAAAAC9v////////////////9va2ckJDQ8AnpuQrQ+tqcmpypAAwLAAAAAAAAAAAAAAAJAAAAAAAAAJAJC8Cp2g6fngCwvvyQC8C8ufn5+8vb25+QkJCckAALAJAAkAAAAAAAC///////////////////+dmpmgkJCfCQytmvCenpraCenpqQCekAAAAAAAAAAJAAAJAJAJAAkACQvLDQqfmtrQ8PCbCskLDaDa+fD7y8vLD56a2pCakAkAkAAJAAAAAAnb3//////////f/////9vpyQ2dCaAAnpsK0J6Z6ekNvJqcnp4AoAAAAAAAAAAAAAAAAAAAAAAJCgCcsJ2g+/ALCw8NALAPCp+p+vv5+/n58LkJCQvJCQCQAAAAAAAAAJ+//////////9v/////2fyfm9qQvJ0JAAycDwnp8J6aC8vKkAkJDQAAAAAACQAAAAkAkAAACQAACQmgCaC9vKngnpAKCfywCZ6cv5/a29sLC56QsJCQAAkAAAAAAAAAALv/////////n7/////b3/n5DQkNkJAACQmpsLyw8PDw0JCdrLy8oAAAAAAAAAAAAAAAAJAJAACakA6Q2g+enp8J6Q8NAAsPAKm/n/r/va+fnLm9CakJqQCQkAAJAAAACd/f//////////37//29uZyekJCQCQkJAACQycvfD56QvK2gCQAJCcAAAAAAAAAAAAAJAAAAAJAAAJALCZnp6eDamgALAAnp6Q6frb+fq9vpqcsLkJCwkJAAAAAAAAAAAL+/////////+fr9/9vQ0AmZD5y7yeCQkJAJCpCtvL2+kNDa0PDwoLAAAAAAAAAAAAkAAAAAAACQkKkJoOkPC5oPDJANoACemsmp+/373629+bD5ywkJAACQAAAAAAAACb3///////////2/+QAJqfvv/++cvgkAAAAACQ+a28vJ6ampCwkJ0AAAAAAAAAAACQAAkAAAkAAAAJC8kJra0OnAkAAKmgCwvbC8veu/+9v6mwmasJDakJAAAAAAAAAAD///////////2trQkAmb8P////mv8J4PAAAAAAkPmtqanJ6csMvAoPAAAAAAAAAAAAAAAJAAAJAJCQ8LDa0PDpCw4AAPAACa2t6b+//fnr258PC9nakJAAkJAAAAAAAAm9v//////////72pAAAP37/b/ryengkAAAkAAAra/b3NCwmpypCpyQAAAAAAAAAAAAkAAACQAAAA2gkNoJqQCaDJAAAJ+pDAmpvA/5+v+frfub0LqZqQmQAAAAAAAAAAC//f////////+f+crQCQsNrZvQsJCQCQCQAACQkJraq8vLyena0KnpoAAAAAAAAAAAAJAAAAkAkLCQqQkJ2p4NAAAAAOkAqayeC/n7/9v/263pC528kLCpAAAAAAAAAAvb//////////3/npmQkJCZkAAJCQAJAAkAAAAAC8mt2a0AmpCpqckA0AAAAAAAAAAAAAAAAAAACgAPCaywoMkAoACQCbCpAAmgv57/z7/wvZ+5vQsLkJCQCQAAAAAAAAn/+/////////vw////mQkPCb2ZyQCQCZAAmpDa0AvbCtC9vJ6cngoPCgAAAAAAAACQAAAJAAAAkJCQmtsJDbCwyQAMnvkKmtrQAPufvfn/+vm8sL29qekJAAAAAAAAAJuf3/////////3/vb///9+ZvJCakJ0LwMkLwNoJC9C8vQ8ACpCaCZyQkAAAAAAAAAAAAAAAAACwAAoLywAAsMAJAACw8A+gCamskJ7/+/6fvby52wuakJALAAAAAAAAAA/7//////////+f+t//////29vJ/anJua2tsA0OAK0Lywn5yenp4KmsDwAAAAAAAAAAAAkAAJAJCQkJrbyQyanKCpDLy/ALCgCpoAufrfv72/vamtmtuakJCQAAAAAAAAm/+///////////n/v///////3/C9+94NCQDaCwn5rcsPAAsJCQmcDQsAAAAAAAAAAAkAAAAAAAAACamgkKmtCwkMqQoJCwALDQALD//728v5y5+Zrb0JDQAAAAAAAAAJ/9///////9v9v5/b3///3/3/+wn8vLCZ6emprQ8A27DQnpDQ8PDgsLDAAAAAAAAAAAAAAACQCQCanpyQmpAAvAyg8OkPoAqQsLwA2/+e//8PvamtubD5CakJAAAAAAAJv//f/////////ev///////+//J6b28ngkA0NCanbrA+ememgkAkJAMkLAAAAAJAAAAAAAAAAAAAJCavLDADwmprfrwCw2pCgCwsKAL/5+fv9qfma2tsJqQAAAAAAAAAAn7+////////9v58Pn9/////f//np8LCQqbCw8NoNm9Cp6QnLDwyw8JrQAAAAAAAACQAAAAAAkAkAvJCQmpkADQr/37wPqQqQsNrQmt6//r37/wvJubvakJCQAAAAAAAJ/f////////37/fnb////////29CfDQnpwMkNCw2w8L/QkPCQ0JqcCeALwAAACaAAAAAAAAAAAAAJCw8J6QoJoL3//ssLAKAKALC8oJvem9+/+b27Db0JCakAAAAAAAAJv73//f//////362/y///////v8vpCeAAC5rQsNsPCckLDwC8sKnAsAnwAJAAkAAAAAAACQCQAJC8vakPCayQy8//7byssAsJqa8PDw+//6np/+sNupv56QCQkAAAAAAL3//////////b+9vJvb/f//3//b2ekAkJAACw0Ly5y7y8kL0JDJCwDaAAnACQoAAAAAAAAAAAkAAJCpywvAvLAPD9+ssLywCgAJCw8PD5/tv/v5+w28sJkJoAAAAAAAAAvb/7////////35+8m9////v9+/+Z6QAAkMkLDQnLnJvby8ram8DQsJ6QqQngnAAAkAAAAAAAAJCwmQvJy8C8sL8On54OsAoKmgoPCa8Pvbyw+fvbuZ/7CwmQkAAAAAAJv//f//////////nbnLn739Cbn9sPkAAAAJAAmg+Q+enpnLkJwJsAkMkOkLAJALAAAAAAAAAAAAAJ6ekLAJrangC8oKCZALCQAAmpoAn62v+f//2tD/uQ0JAAAAAAAAAL29v/////////29vpy9///5n5/bD9DpmpCakNvJkPnpy569DLCwwPCpoJAAywnwAAAAAAAACQkJCempCwy8vLywsLDwmvsACgoKCayeCf/9vtr7/7+an7mtCwkJAAAAAJv/////////////35sJCf//////2/vayQ8NoACfDw+fvenQucnLCQyQCcrakOAJAAAAAAAAAAAAsJqevL6a2ssKDKAKAA+pAJCQoJoJoJr627/f+9v5+ekJAJAAAAAAAJ29vf//////////vf35+f///////a25rJCw0JqQvby8mtqfy5qcsLAJ4JAJCQng8AAAAAAAAACQC8kJy8vPCw6csJqQsPAKCgoKkKCwCQ+f/9+/vf6fvp+akACQAAAAAAv//////////9//378PD5//////3//NmenLAJyemtvb/b26nA2wnAngkKkMoJoJAJAAAAAJAAkAkJrakA/6zwsKAKAKAJCwCQCQCgkK2vD7y/r//729vbkJCakAAAAACZ+fv//////////f+/35+f///////9ubDpywCwnp/a2tC8vJ29sMsLCQsNCpCenQ+eAAAAAACQAJqa2prL2t8LDwsLy8sPoKCgoKCQqQsJrb/9//n/v6+/CwkACQkAAAAJv9///////////7/fv/2//9//////7ema0MkNqdqfvb/fn+vLybycqcAA0AkJCpAAAAAAAAAACw0JqcC9raD8oA6enp6g+QkAkACgCgCpAMv7+f8P/5/b/byZAAAAAAAK2////////////9//37/b3//////f294JqQCa2p8NrQsPCZ2w8MsJALywqcoAsPCQ8AAAAAAJAAmtmr2vytoL27Dw+v3/CgoKCpoJoJqeCwvP//v7/fu/mwmgkJAAAAAJn9v////////////9/9//////////vanawLC8kPD72/35/+npD5Da2gkJAKnJDQvLAAAAAAkACQsL7QvwCQDwoMsPDQ6rALCQCQAKCaAAkA//v//9+/ntvLkJAAkAAAAJ+//////////////b//+/////////3p2gmcnLv/np2tq8sJD5+a28kJysAJAACa0ACQAAAAAJoLCfmvwNDr2prbrL6vvcsAoKCgoJCgsLDpAP/5/7/7+7+a0JCQAAAAAJv////////////f//+9//////////+9rZ4AsJyQ+evb/b3/+emtkJraCZoAkLAAC9oAAACQAAkA+trQsKkMDwmg2wkACrywkAkAmgCQCwsOsJr///v9/fvbmpoJCQAAAAmf/////////9////3//f///////9/L2gm5y8v56drfD9qdr57a6ekNoMkAAAkJAJyQAAAACQCQn62sAJCwsPCaAOC8kJoAoKCgoAoKmgCwDK37/9+fv5rbyZCQAAAAAJv///////////+/29/5//////////+9rbwMsLCenr2w+a362em9npra0LAAAAAACamgAAAAAAsNsJqakMrA8AvJrQsKCukKCwkLCakJoJra2gm9+/v78L/7kKkAkJAAAJy////////////f/////////////9/LyQCbDQ3p+dvP2t+p2vnp6a0JqQwAAAkAkJwAAAAAkJCavLwACgkLALAKkLAJqZ4JAAoAoAoKCwsKkADr///an5mw+ZCQAAAAAJvb/////////////fv9///////////5Dw8MmtueD+2wvanevQ+emtq8npqQAAAAAKngAAAAAAD5ywvADQAAmsmtrA8OAKmgqQCwmpAJoKCw6QkNv9v/m/Dbnp2pCQAAAAm9//////////////3//b3///////nv8JCw0Ky9ub79r9qZ69rb3p2p6cAAAAAJCQkJAAAACQsKvAAJoACsoLCampqQsNoJCgoAoA6wy5ypCgAL/7/56Qu56ZqQAAkAAJCfv///////////////v//////////5Dw0JqdvJ78kL0L3pnK2suenLCakAAACQAAvAAACQkACdCwCaAJAJCQDp7awKwKkKAAkKCakAsAqcoJALy9v/vbkNuaCQCQAAkAvb//////////3//9//3////////96c8JoKnay60Jv+y9qay/m9vLy8npwAAAAACpyaAAAACpsKAMsMkAyaCgqamgmpC9oAqaCpoAoLCamgmgkJ//+/mtC5D5kJAJAACQC5////////////D6/b69/f///////7DQDZytvNrawJm8ntucvLy8sJ6aAAAAAAkJoMAAAAkADJqQAACpoACQkNrJ4KAK0LAAAACwng6tqaCaAAC9rf+bkJua2wkACQAJkPm///////+9vp/by936+/3////9vNsLCgsAmp2tvKwKkA+py8va36nJ6QAACQAMmwAAAAAJCwwLwLDAmgoKCwmgCQsPCgCwsLAOoLCaDpCtramv+/vp6anJsJAJAAAACbn//////9/f+fC8kKkNntv//////7wA0JDJ4MqQCQkJC5DanbyfCcupAAAAAAkLDJAAAACakAsACQCw4JAAkKnLCgAAsAoAAACpCaypqQqakAy9v9+ZkJCbyakAAAAJnw2/3/////+/D8vQvJD5rb//////y8kJCsCwkJnAvLysDAy568usnrycoAAJCtCpywAAAJAADLCcsA8AmgqaCtCgvJCvCwkLCgsKDgsOmpnprLAL36/6mwsJuQmwkJAACZqb/////5/f+b2tCakAkPn//////awKCQkACeCtAAkLCQsOnLDbrQnpyQAACQnLALkAAAkJqQygnpraCQAJCamtAKkLwAoAqQCQqQ6QoOsPC8vJrb29rQnLC8CQAACQmp28v9v/+/+8vACQAJCa2w+f////35kA0LycsJAACQAAAACQsJ4NC8sLAAAAAKCw8MAAAAAA2pvaAACgoKCgCpAKkAoMsKCaAKCgmgmtCwCgsLCwv/v/mbCQnbkAkAAAkJqb2//b/fDwkJ4KnAsNCdv7////+soJCgCwDa0LAAAAAAkACemw8Ly8sAAACckNALAAAJoJqcoJy+kJAJCQsArQ4LybCwCgmpAJoL4KvJqfDw8NC9vbywmwmpoJCQCQm5m/n72p2wkJ4AANAJyQrbD9///9rZCeCQkA8AAMAMAJAAAJDwkOkNDwwAAAmgDakJAAAACanLDwsAAKCgoKAKkKmgCvAJqaAKCgAAC8Cq0KmqCw8L+/ufAJCQmwAAAACa0J69vaAJD/8AwAAKAJAJ+/////+gAJAMAJC8AAAAAAAAAAAJ4J6w8JoAAAAJqQAAAAAJAJ68kPCpoACQAAqQ6wAJ6Q+gAJoAkKmgALCaC8vZvLD56f+bkLCfAPCQkAkJuZmevZAAm//gAArJ4AkAn5////39oAmpAADvCgAAAAAAAAmgnwnLDw0AAACQwPAPAAAAC8kL8K0AALCgsJCpAOmgoPALCgCwoAAJoA4MsLCqywvL+/nr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CpCQoMupAACgmgsLCaCQAKAKCQoACQvL/56b+fv/kJoJn5qanQkJDwkLn5vPuf+f29va+fvrn+2/vf/rz+vL372tvLrKkAAAAAAAAAAAAAAKnp6ayakAsAAKmgqQAKkAAKCgALyaCpAAoJoAoACgqQCQCgALAKCb2//9v729rQkACw25+5qQmb29Ca257wvbra352t+f75/P3629vb376erby8mcAAAAAAAAAAAAAAkNCaAAsACgALCgAAkKmgCpoAAJoPCgAAoKkKALAKAAAKCgsAsACwme//vav9r7makAmfsNsAkLDwmpu9ufm9vL358L//nt+e+/r9/e2v6e2928vJ4KAAAAAAAAAAAAAAAKC8nLAKAACgCQqaCgAAoAAJoKAJsAsACQqQsAqQsKAAAAAAAKAAoJqf+/y/8P+tqZoJ26n5AAmfna0J6enL29qen/Dw/7/5/f2/r7/b357avLyanAAAAAAAAAAAAAAAkJ8LoAoJqaCaCgAJALCgkKCgAAAOmgAKAACgCpCgAJCgkKCgoJoJAA2/37/b35/b2tngvdufmQCwuZufmb+by5+b2tvfn8v/vr/P39r8vvn96entqQkAAAAAAAAAAAAACgn8CwCgAAAAkKCgoACaAJAKCwoL8LCgCgAAsKCaCgAAoAkAkAAKC5oL//+/++n/rauZC6nrCwkJ2vCw+8nam8vPvby7z73p/f29vL+f3b6en56awKAAAAAAAAAAAAAAkJ6QvKkAoKCgoAkAAKAACgqQAAAOAACQCQqaAAmgkAoAAKAKCgoAkAyf+9vL/9v729Cem9+50JC5qZnLkJup/L27y8+8+9+/y/r/7/z/6+n58OmtDQAAAAAAAAAAAJCayevKAAAKkAkAAAoAsAAKCQAAsKmrmgoKCgAACwoKCgCwoAAAAAkAoLAA////v/8PvL256bn5qQnL2em9qenQufntvb/fva/Pvf+fn58Pn976357aCpAAAAAAAAAAAAAJCpAMCwsAAAoACwAAAAoJoKmgAAAMsJAAAAoLAACQAJAACaCwCwCgkAmpC/vb2//9+avLnp6fnpqQupCa2ZqfDw+by9r579v969z+8P/56fnPrantkMAAAAAAAAAAAAAAkLwLAACgCgAKAACgCpAAAAALAKALygoJCgAACgsKmgoAAAAAAAoAoJrAvf/+va2/r9+fD5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CgAKAKAAsAsACQCgAKAKCpqQoAkACQAAsLCgoAkJALCgsAAJoKAMoLCgCaAAAAAAAJCpAAAAn77/3/////vb7b2emvmcvp/Lufn9vdr9vLz96enp4ACgoAALAAsKAAAAAJoAAAmgCgAAAKAAoJoAAOCgCwoKCgqQAACQAKCgoACQCgoACQqQAAAAoAqaAKAKAKAACpCgAPvf//r////tvr+t+f652wvfzw8L+v2v29vgvL2sngCQCwoACgAAmgCgsAAACgAAAACgoAoAkAAKANvJoACQAJAKmgoKmgAAkKCgAJAKCgkKmtqaAAAACQAACgCgqQCQAAnr////2////fz77+n+vP+vv///z5r9r+2/y8oJoAsKAAkKkAoAAAkAAACgqQoAoKAJAAkAoKAJAKAKwLCgoKCtoJAAAJqaCpAAsKCpAACgAAAACwAKCgmgAACQAAoAAAAJ////7///v/+/29vb2/n/3/np++/a/5D8sPDawAAAkKCgALAKCgoAoKAAAAAJAJAAoAoKAAAKCtsAsAAAkAkADKCpoKAJAAmgAAkAoLALCgsKAAoJAAAAqQoACgCQoAAACf3////P/L3///7+////vv//7b2tvP8LwAAAALCgoAAAoACQAAAAAACQAKCgoACgCwAAAJoAAKywCgoKCgoLCwkKyQoKkKAAoAoAkAoACQANCgAKAKAJAAAKkACgAAAAAAr5//////////n5/////b+f/+/+/w4MvAAAsACQAKkAmgCgqQoLAJoKAAAAAKAAAAoAmgAKAPkKCQkAAAkAAAoAmgkACgCwCaCaCgCaAKCgqQoACQCgCgAAAAoAsAoAAAkA+f/////p8P////rfv/7//9//C/nwAKCpAKCgqQCgAAoAAAAACgAACwCQoACwoACaAAoJAKDpAKCpqQoKCwCQoACgqQoACgCgAJoACgkJAKkAoKAAAAoACgkAAJCQkAAPC8m//////////9//////3r/Ang4MsAkACpAAAAoAoJAAoKAKAAAKAACgCQoAkAoACgkKCvkMoAAACgAJAKCgCakJCpAKAAAJCgAKCQCgoACpAAkKAAkKAKAAoKCgCaAADL/Ly/n/////////z/3+qfDwCf2wDwoKkAqaCgAJCgoAkAAAAKCQAKAACgAKCpAKkAoAAMqwCwmgAAsAoJALAA4KAKAJqaCgAAqQoKAAywAAoAoACwAAkACgkAAKAACwCQrQ/P///e3///vb//6f3g/KAL7fAAAAoAAAkAsKAACgoAsAqQCgAAAKAAqQAKAAoAAKkL0KAAoJqaALCaCgCwmtqQmgAAkAqQAAAAmpoKmgAAAAoAoAoAAACgkACpAAsK0LCwvKD7//7w/vy8ngC8sJy8v62pqQALCgoKAACwCQAAAAAAAAoJoJCgAKmgCwALCgCsCgkKAKAACwCgyQsPrangoACgCgAKCgsKAAAAAAmgCgAAAAAKkKAAoLAAoKAJCskAy9+8sAkJ6QvLwAvJ4OsL2toAAKCgCQAAALAAoKCgCgCgoAAAAAAJCtAJoACgAJoLsAoJqQDprL6amvD5//8JwLCaAJoAkAAJoKmtoKAACQALCpoAAACwAACgCQAKCQrLAAAAAAAAAAAADwAKkJCsvamgoAkAoKmpoAqekAAAAAAAALAKAAoAqaC+C+kACgAM8JCgCgkKm9vLDb/////6mgrAmgAKCgoACQ4ACQoAoAoAAACwoKAAsACQoAsAoKkAAAAAAAAAAAAKALywoKCaCsAAmgoJAAAACwCp6wsKkKkAkAAACgCaAPAL3L6ekKkJoKCQ6QoJrb/w///////88JywoAqQAJAKCgCaCgkKAKAKCgAACQAKAKCgAKAJAJCpqaAAAACgkAsJywAAkAmgkLCwAAAKCaCgAAsPnwAACgCgoAoAAACg2gv8v/DwoACunpAKkKCa3//L2///////qeug2pAKmgqQAJCgnACgkAkAkAoACgoAAAAAAAAKAKAAAACgsJAACgAAoKCwoKAACgAAoAoACgCQqa378OCgAAAAAAAAqQoJq9/L/9/62poLAAqQoJypq9+/D7/////735/foAoAAACgsKAAoLAAoKCgCpALAACwCaAKmgoAoAqaAKCQAAoLAJrakJAAAJoLALCgAJALAACgAJqfywkAoAoAAKkAAAkKyev////fDgANupCpCgsA2vvLvt+/v//fv///2tCpCpAAAAmpAAqQAAAKAAoAoAAAoACQAAkAAJAAqQoKCgAAoKAAoKCgoAAAoAAAsKAACpAAoKnpvKAAAAAAoAAKAKAJq56f3///+fALwAqenLALCfDwyb/en76/3//56aAAoAqaCwoAoLDgsKkAmgAAALAAAAoAAAoAmgoJAAAAkJoPCQmpAAkAkKAACaCwAACgAAoJAA2toJCgmgCpAACgAACgAOn/////DgoMqekLCwCwvw8Nu+mpsPn5+//+2gCwkLAAAAALCQAAAAAKAACpoACgCgAKCgAKAAAKCgsAoKCQCgoAoAoAoACpoAAAALAJoKAKCpoLDwoAAJAACgAAAKCQD5////+86QkLmprw8JrJ6f++8Nra356wvf/braAKCsoKCwsACgoLCgoAALAAAAAJAJAACQAAAKkAAAAAAAoKAAAACQAAALAACgoAoACgAAkAAAn/+fAAoAoAAAoJoACgsKv9//7bCgoM8JCpDgmpv//5/72/v72toLvtsAmpCQkJAMC8vAkAAJAJoACgCgoKAAoLAAqQoAoKkACgsJCQsLAKCgoLAACgAJCpCgAAoAoKmgqf/p6QAAAKAAAAAJAAC8m///2skAALqa+euQoP////8Prf3/ywvf2/DpoAoKCgravLCpoLCgoKAKCQCQAAAKAAAKAKCQAACgsAAKCgAACpAAAACgqQoAAAAJCgCQAAAJv///CgCgAACpCgCgoKkL7f79oLCpoJ2vkLDKn7///9qfn7/9vp+///ywAKnpya2r376eAACQAACQCgoAoAoAAAoAAAAKAKAAAAoAAACgAAAKkKCQAAkKAKAKCQAKAKAL7fnwAACQCpAAAAAAAJDr2/n6DwAAAOsJ68sJqf////8Kn///+f////vAsJC6vpvf/98JCwoKCwoKAAAAkAkAmgCwCpoAAJALCpCpALALCgoAoAoKCgoAoJoAoAoAsAsAm74AqaAAAAoAoJoAmgqQ688NoKCgAJ65C54Kmt///w28qf///////9+8AKydvf////76AAkAAAAJCpCgCgCgAAAAAAAJoAoAAAAAoAAACQCQAJAJCQAJAACQAJAAAAAKDAmpAAAKAAAAAAAKAJCpALCgkJCQoPkOngmpy7//+/oJv/////////8LCwu///////+csKCpoLCgoAoAoAoAoAoAoAoKAKAKAKAKAKCgoKCgoKCgoKCgoKCgoKCgoKCwmpoAoAoACgCgCgCgCgqaCwqaCgoKALCpoJoAuf///wALD/////////+eAL3///////8KAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABBQAAAAAAALStBf4="),
                            Address = this.Addresses[6],
                            Roles = new List<Role>(){this.Roles[1]},
                            Claims=new List<Claim>(){this.Claims[0]},
                            SecurityStamp = "a55afdff-c923-40dd-91b0-9a7cdf0b5baa",
                            LastActivityDate=DateTime.UtcNow
                        },
                        new User()
                        {
                            Id = new Guid("a3fdbaf1-6c81-cb3d-1f79-08d1b9e8f1ce"),
                            UserName = "Andrew@aaa.com",
                            PasswordHash = "AEGzcTci8/MDp+bDJMk12Q1222/gU3yERiFo5MYQv/3qdBb9OhVj6l4DsUjfK2d3mw==",
                            TitleOfCourtesy = Civility.Dr,
                            Gender = Gender.Male,
                            PhoneNumber = "(206) 555-9482",
                            LastName = "Fuller",
                            FirstName = "Andrew",
                            BirthDate = DateTime.ParseExact("02/19/1952", "M/d/yyyy", (IFormatProvider)CultureInfo.InvariantCulture),
                            Email = "Andrew@aaa.com",
                            Photo = new UTF8Encoding().GetBytes("FRwvAAIAAAANAA4AFAAhAP////9CaXRtYXAgSW1hZ2UAUGFpbnQuUGljdHVyZQABBQAAAgAAAAcAAABQQnJ1c2gAAAAAAAAAAAAgVAAAQk0gVAAAAAAAAHYAAAAoAAAAwAAAAN8AAAABAAQAAAAAAKBTAADODgAA2A4AAAAAAAAAAAAAAAAAAAAAgAAAgAAAAICAAIAAAACAAIAAgIAAAMDAwACAgIAAAAD/AAD/AAAA//8A/wAAAP8A/wD//wAA////APAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACf///////////////////+AAAAwAv+AAAAqQAP//////z////8AJ/8AAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAn////////////////////9sJ8AAAAA/L/+ngv//////w////wJ//4AAAAAAAAAAAAJAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAv///////////////////////4AAAkAnwn/wL//////8P/////v/8AAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJ//////////////////////8PCwAAD/AAAAC////////f///w+f4AAAAAAAAAAAAAAAAAAAAJAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP/////////////////////+Cf/8Cp8AAPwAv///////6///z/78AAAAAAAAAAAAAJAAAAkAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC///////////////////////AJy+CcAAAAAL/////////f/8v8kAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAn///////////////////////wACf8L+p8Km/////////7////AAAAAAAAAAACQAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA////////////////////////8An8vA3//9//////////+fD8AAAAAAAAAAAAwAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJ////////////////////////AK8AAAAAAL//////////7+AAAAAAAAAAAADQAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACf/////////////////////////p/AC/AJC///////////38AAAAAAAAAAAMAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD//////////////////////////Qnr/Jra/////////////gAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAv/////////////////////////AAAAAACf////////////wAAAAAAAAAAJwAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJ///////////////////////////wv9v///////////////AAAAAAAAAAkAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP//////////////////////////////////////////////AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC//////////////////////////5+f25///////////////+AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAv////////////////////////f2//7//mf/////////////8AAAACQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJ///////////////////////9u//5/fvf/5v////////////wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP/////////////////////5+//fvf+//7//+f///////////wAAAAAAAAAAAAAAAACQoACcsNqamvnpvpAKAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC/////////////////////n///+/+/v9+///+b///////////gAAAAAAAAAAnKkKkPAMkL2pran/n56b2bDJwPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAn///////////////////+f//vf/5/Q+fnfv///n//////////AAAAAAAAA2tqZ4Jyw+by9rZ+b2wvLmtr8uan/AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA//////////////////37/7+f+9qfCtCwoJ25v/+//////////gkAAAAJywub2pn5vbD5sLmrD5rfm9rbmby9qfAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAL/////////////////b+/2/zw8P38va0Nnwvv37///////////AAAAAAACcvPC8sPC9uen56duemw8L2w/pua2/AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC////////////////9v//5/w+f+8sL0Pmp4A0JC9+//////////AAAAAwLn7m5vbn5vanpuemanprfmfmtuZ8PnvAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAn///////////////vb29rerb2pyfnw+9ranbDw+enb//n//////gAAALCdqcvPCemp6fm9D5rb25+anpra2+nw+fAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA/////////////76fv76f29vLy/vJ6fng29oNsJ4J6cuf///////AAAkACp+5m58J+fmw8Lmemtranp+fm5rZqbD/AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAL///////////9+f37zf2tqekLnJy/vL/b8Pn7yememtD//5/////gAAwNvbDa0PC8m8vPm8vJvbm9ufCw8Pm+np+fAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACf//////////27v/uc+wvLDwn96fqQ25y9D56cv5npD5qQv/n////AAAC5qa25vwvbvLm5vL272p7anpufnwvJufmvAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAn/////////n5vfyw3LDbydvb8Knpn/D8sPuen7yesPCe28+b+b//8ACQnL29sPCbyw29ra25qcvbm5+enpqb2/yw+fnw8NAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA////////2b+f+5/LC8sNvp6Q29ueCcsJrQ29qdvZyZ6Z6bDw/////A8Km8vLy58LnbCw+bnp25sPDan5+fnpqbnbD/n5m7+ZDAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP//////+wv/D7za28npvLDQmvCeDZ+anw2p4J0KAPC8vanw8PD7n/8AAJy9ufm8vfCw+fkPy8sPD5v58Lyw+fn56w+fsL2v28+a0JoMvLAAAAAAAAAAAAAAAAAAAAAAC//////wvZ/5+cmtoJ8JycsL/Qnpn6mtnp+fmfD5+ZvZsP0P+fnp//8AmtqbDwvLmwsPnpr5ubnwuQ+Qufm9sLy8udsPnwvZqbD5Dw25Cf8AAAAAAAAAAAAAAAAAAAAAn////7yfnvnw8Lyanamempy9C/2ekN/an5vLy8vby+2+35v5nw+em//AAAnJ+b256fnQufkPnp6fDbD7zwvLyfm/yan7y9q9vJueubrb+prwAAAAAAAAAAAAAAAAAAAA////6Qva2/npDQvJ6Q6Q8PkL0Lqf+5qfnp+fn58Nvby5++nvC/np6f8AkJCwvLDZvLqbyw+by5mp8L0Jufm5up6Zvpqf+Qna2w252tm8nb2cAAAAAAAAAAAAAAAAAAAP///Qm9+58LyempyakPnLCQvan53wn9n9rby9vem/vfvcvZ25/f+/2f4ADgANC5+6292tufC8va2fC8v7y56enbn62b2/mp+rkNqfC5rbm+mrwAAAAAAAAAAAAAAAAAC///y5vPsP0NCpCcsJy5yw/by9+evb8L6b29v56b/9D7378PsNvw/9vpAAkJCwsNsNmpqZ7a2b2purn5ucuen58Ly9utqfnanZ6bnpvJ+p6Z+cvAAAAAAAAAAAAAAAAAn//pna2w3wsL0A8LD6nAudsNvan5D5//29v/3/n9vb+fv9v/n7y/n6+fvAAKwAya2wvb2tubDwva2c8Lz735sLD5va2b2vq9q9mtuem8n5npr5mwAAAAAAAAAAAAAAAA//mevb37CenADwn8kNvbDw2629C/+fmfv/25uf+9+9v5+f29/b3f/f+v2/CQCQAJqfC8ua2tufC9q5vbnwsP29sLy5rQvfnanavQvb0LD56b2a0PAAAAAAAAAAAAAAAL/wnpmtsNsACamfAJvbyw+anNvL/b3w/5vb/f//n/vf/f/7//v/up+/n5/LwAmgkOnJvbnLn5y5+Qna2tqfn5ra29vw8Ly72p+p0Ly5q5+am8vpv5sAAAAAAAAAAAAACf4J+drZraDQ8Nngn/Dwufnp26nb256/2/3/2/n5//n7+/n/29/5/fvf/a+/sAAAAJCa2py7ywu8vL65vbn56a25vJqfm9udvanbr5vL0NqfDbmekNDwAAAAAAAAAAAAD/mbyw8OkNoJCwqdsJ+f3p6dqd69rf/b/b+/v///+f///fvfv/n//5/72/28/wCcsArJn7nJvbyfm5kPyw8Pm9sPCb3wvJrfy56dkPm9qb2p8NqZ65vLAAAAAAAAAAAAvwDbDbmw8AkLydC8vampuemp+/n5+5+9v9/f3/n////9///9+/+9v7/b77/72fAAAJAKyfq8mtsLyem5vbnw8Pnw+pqfm/mvuem+vQva28ufC58Pmem98AAAAAAAAAAA/AvQ+Q0NAPDQmp+b2tvfD5+fDQ+fvf/fn/v7+///n/n/v9/7/f/f////n9vfvr8AkMCQmw2bn5D5vwvLyw+b256b0Pnw8J6fnpnpkL2tsLnpm9rbnpnwsAAAAAAAAAAL8L2pmtoLCQmp8PCen7y5+cvJ+/n7372r2/3/39+f+////7+f//v7/f/b/7/r/98AALAKmtup6emw8J29ufmtqem9qb2tuen9uQ+by8vbDa28vLmQ+eqfnwAAAAAAAAAPwNrbyQCcng+cufn58J/a2/n729/569v9vb/5+////fn5/f//+/3/+/+//9vfn6/wAAkJyanb256fn5qbzw/bn58L28ufD5sL7bDwsJC9udsL29r5qZ2p68kAAAAAAAC/wJ0JrQ2gCZoLyw8Pn5vfnL+enwn/n/n729v/n9+fn/+/+9+9//+9////2/+9+9vfCQDAAJ6anpmp6fnpubC88Pn5qb2psPn/mw+b0L2w8L29Ca2enwufmZrAAAAAAAD+Cam8kLAJDw2dvb29v8+7m5yb2/+f29vb29+b2/v//5/b3/v/vfn/vb+9//3/vf+/4AsJqckNufDb2wufDw+bm9qenwvby56fsPm8C8sPm8vam/mpsPnpra2wAAAAAA/w2p8JAAyemtuesPva+bv8/8u9rb28ufn9van9v5/9uf+9v7/b/7/7//3/v7+72/+f8AAAALD7ra2wsPnp+fm8vLn58L28uem9+Zrb0Jvby729rQvQ+Qm9sJC9AAAAAA//CcngnpsJ8Jr5nw+fn929ub39vfvb372t+b25+fn7373/2/29+9vf2/+//f/f/w/73wAA0AkJ25qfnw+fmprb2w8PCem/y5vLz52pqcvbnQsL29q9D7ya29vLkAAAAAn/ybCQAADwn52+n5/5+r27z/m+m8n/vb2bD9rb29+f+fvb/fv73/+/v7//v7+/n/n/v/CQoJ6anp0Ly5Cw+fnw+fm5+56b28u/uanb2pC8sL29qb0LmQm9sLCfDgAAAAC8oJ8MkNCQ8PvJ+fC/3fv8mb7b/b+dnr+9ufm9vbn/n9+9v73/+9vf39+f//35+5/w/fAAkAAJ+fC9uen5vLy7nprakPn5rb0Pnp+tqcvb28vQuem9vpr56cn7CQAAAAAAmfALCwvpvbyfC/nwu735v/29ufn7v5yfn5n9C9+5/7///9+fvfv/v7//+fv/+f+fv7wAANCemwvanp2p6bm8+Z+fn5ra2+n/mwmb0LnpqZqfDbyamfkPmwqcvAAAAAAAywsADbycvJv7/J+f/d+f+bv737+f2fv5+f+725mfn5+fm/v9u/29//////+///v///8AmgoJy9C5+am9sNrbmvC8sPm/m9qf7by8vQm9vL2p8Lnp6Q+a2dm5m8kAAAAJrZwNoJv5m/29n7/5v7v5/9/b+fn7+9vbn5/Z+f+fn529/Z+f37//vb/5+/39v/27/b/wCQCanr0PD5ra25+enb256a2w8L2tuQufmp6byan5C9qZvbC9sLra8JrAAAAAmaCQna0PD5vL+9rf+f2/vb+9v/+f372/+fm/nwnw+evbn/n/v/+///2///v7+fv9+//wAMkAmZqb2w29sPC5+prbn5vbn56fvLnpqcuem52wvan7ywnLDw2fmekAAAAJy8Cw8Ln5/a35/b2/n9v729/f/5m9u9vfn7/9n5+fn5n5/5v729/7+///vb3/n//fvf/wALALD60PC8uprb28vb2w8PDw8Pm/memb2pn56esPCfkJ+em9uZq5y5+QkAAAuQnJm8mp+9u9v5v5/7/f/7+5+f/737/7+fn7/b29sP+fn7/f//vf/f+9//+fvb+///n/AAAMkJu5+b2f2prbm9qfm5vbnwvL6Z6emeC5vZ+b2p+wuZ6a2tnLvLDwqQAJy8qawPn9Dw37/fn/m9/5+f/b/5+fv9vb//+fu9vb2Zvbydv5+///v73/vb+///3//7//sJyQrQ0PDwsLn5+enr2w8Pm8ufm/28m5vJva2pqemfDb3pm9ubC5y5+fnLkJuQkNm58Lvb+fn7+9/7+/v73/m//5/b+/2/n/372tvJy5v72/3//7//v7/739+/+/n//7wAoAkLC5+en56anp/bD9vQvL2p6fsJvp6b2tufn5nrm/C5ra2g28uempCwwL2gnpra29/b2/+9n/+9vb39v5/9uf2/n9v9v5+dvb2/uf29vfv/v9+f39+9+/v9vf//+f8AkJC8m8sJuem9vbmp+amr29qfn/na2fnanbya28ucvJva29vZqb0L29vbkNrQCfn58Ln6nb37/b3////7/b2/2/vf+//b37//vb29n9vb2/29//v/v737/////7/7//8AAOALD5+fD58Lyw+fD5+dvLnwsP+pqbqdqbvZqby5+9qZqamtnLnwvLC8sJkNqcsPn9rfv9vfv/vb/7/fv7+b/5+5/b2/vb29mfnb29vZ/Zv7//+f2/+9vb2/v9+9+//wCQkJyanpsPn5vbD58PDwu8uf2/Cfn8nanw2p28uekL28nb2am56Z+Z+ZAL6anL256b+/2//735+/+f+//9/72fvfn7/5+9uf////+fn7m/3///v/v9vf//////v///vwAArJqfm5y56emtueufub372prfnwmpup+9uesLnLm8vLm+mpy8m/C/Dw+ckMm5y9n9nZv9uf+//f////vbudv737v9ufDfn9v/29/b+d/9v/+f/5vb//v5/5/7/////wAJCQnLy8ufn5vbD5nwnp6Qvb2/sNvbycva2p28m96fm9rZvamb8J8JsJCby5rLn6+b+/2//5/b+/v7+9//3735+f2fDZuf2b25+b+f372////pn//b+/3////f/7+f/5AMCgub2py56a2tvb6b+fm/y8sLy6mtubD5van56bmp6b2vCdrZDwnw29CfANm8udvPn7+fnfu9//3/37+/+9u/n78Judn5vZ/b39vb+f/f//+QCfm9n7v7+/v////73+CakMDwvbnpvbnwsPnw8Ly5vb29+dvbytuf6Z8LmenbnwuZ+wmw+b2psLD7CaDb27256f+f+5/fv5+9v//fvb39vZ29nLmb2/m9uf2529m9mQAAkJrb+d/f3//7+f//+/AAAJCb2p6by88Pn5rbn5vemprfqa2tubnwmem9D5+w8L2+kJ6fm8ufCcucnp2/D9qf2/n7/f2//////5/735+QAACQm5y9nZnJCQkJCQCQkAnb3L2fn/v/v9////v///AJywuem9mtvbm58L2w8Ly5vb2vnJua0Nrb2pramvDbn5rZvakLy56Q2wnwCZqdv5/5v9v5v7/73/vb//+fvbkAsJCQCQkAkACQnJrQkJnLCfm9u9v7/5+f+/v5//37//AAAAy56a29up6en9qfm9ufy8ufu8n5ub2wvQm9mb8PC9u8udvbnLnpAJC/mtnw/bntvb3/29vf+///n/v9+9qdm9sNkNCQm529m9mfn5+dvZ+f2/n9+/v5//////v/+/wJqQkPn5qa2fn5sL2p6a2puby/ybqfDwvfmp8LDwm5+QnLnpCw+56QAA/QDavLm9+b2/v7/b+////7/737+fn7/b35vbnb2fmb2fn5vb273737/5/7/9//+fn7+///n/sAwKDwsPn5vpqen/m9vbn56embm8nLkL2prZCw29v8vL+56Q+duckAAJmwm5258Pm9v529/7/fvb+f29v/n5+/2/m/25+9vb29+9nb2fndv5+9+f+f+fvb///9//2///wJqQmb356byfn5vLDw8Ly8uby/0Ju9rQufkPvZqbyb2wkPn5Crybn5+Q6QvJrfn8v/D/v/n5+/////v/+f///b/f/b/fnb29vb3/+9+9v72//7/5//////+fv7/7//+/8AAAy8sLn5+pqa25+bm9vbD8sL68nLm5yw+QmtnpvwvLnwsPnZvZ/fn5npy/mp6b0PvZ2/v/n9v9vf25/5+/29v5+fn/+f/b3/////vf+f////n/v9v9v9v9/fv//5/78AnLAL28sPn9vZrfDw8LC9ub2/mbC56cufnp+bqfCfm56b2wmp2/+///CQqQ+fn5v5+/+f3b/7+/+/v/+f/9v/n/+9v5/5+f+/ufnb373/+////5/b///7/7+/3/v/+9/wAACbD5+fqa2r25+fm9va2tqfDw2ekLnpqZqcnan7y8uekNrZ/53/2/kPnfnp69+fnb37+7+f3735/fn/vb/b/7n/n5+fm/n7372/+f/7/f2/+f+/+fv/+fn/+//7///wmgnw+bD72fm9mvnpra8Pm58NsJq5+cufnp2rC9sNuZy5+bm/n/vb/98J6a2bnLnw+/v5/f//vfv/+/+9/729v9+f+fv5/5/fn9v5+/v9v/v5//n5//35///7/9//37/8CcAJvJ+8vpra+em5+b2w8PC728namp6QuanZ8L2w+pvLDw2f+f+9v/+Qn5rZ+96fn9n/m/n/+9vb/b3729v/2b29v52/n/v/+/3//f29+/2/+f//+fv/n/n///+/+///AJC8C7Db29m9n58PDwvbn5+fsJsPnJm9vJ8LC9qfna25+Z+9v5vfn78NsL28n5vb+b/5/5/5vf//n7+/v//bv9np+evb/5/wn/v/2/v/vb/fn729v//b+9+9v7////n/AKAJvQ+5+a8Lqem9ufnw8Ly/DbDbC5vLCbDwnanbC9uekP+dvf/52/0LD9vLv5+fn/25+f+f//vb+9/9/fn73b+Z29n5+f+fvb25v9n5/9v5+9///b2//b//+f/7////wJDw2pvesPn535vLDw8Ln9uducuw2em9vJ+fqfmtvLD52529ufn/vfDb2a250L2/6bv9v5/729+9vb2/v7+f+9u/vb+en7352/n9/b+/n73/n/ufv/v9v/vf////+fv/8AALD7y735sPqw+fm9u88Lz62pybqZrbCwsJ2p+am9sLCfv/2/+f+/sAvbDavfD5n9n72/n/v7/b//vZ/f29n7398NvbnZv/+e+/v9vf/b+9+f//29+f29+/v/v///+f+gkAkJvZqen529qbyw2bn5ufvQucnw2a2cn5qfCdvLDb29mb/5//n9yfCfC9mp+f+fvfv9v5/fn/29//u/v/+9vbn7D5+/2fn5nb37//v9vb/729v/v7//v9//////vb/AANrby/n5+evbnw+fvtqenvkLnpsJutmpuenwn7C52pvb//3/v//bCwnwvb6fm/n7273b/f/7/5/7mb35/5+fn729+f29v/8Jyw+f/72f//29/735/f373/////+//Z/wCaCQvw8LD7npy5ua2bn5+Z6cma2a2bDa2pC9sNnwuf39vb+f/5+/Cf6fnpn5/L+9v9u9v5+fn/vf//2/n/n5+fnbmb/b/Zn5udv5mf+9vb//ufv/+/vf+/v/v///+//wAAkPnbn5+a2/sPD5vp6em/mp65rZrQsJvb0L26mtqbv/+fn/n//b0Amtuenan5/L2/2/n/v/+f+9+b+dv7/7+f6dv9m9vwCf252/wJCb29vf/9+fn/+/3/////+///v9AJ6Qq9qen58J+b28m9ufD/6Qmema2728kJqfCdvZnf29v5/7/5CfC9vbDZvp+9ufvb+f+9/b3/n/v/n/n9+9/5mwnbwACdubn/vfuZ+dv5/5vbv/+9//v///////vb3+CaAPnbvbnpv/C8sL8Ly5+bmfnp2tqckLC/nwvLCan7+f+d+fyQn7Da0P2b6fnb/b2/n/nb+/+f/5/5+9ufvfuQ+f2wm52a2f/b27//n7//+5//39vb+f////////////AACQmvyw+by5n5+fn9uem/ywubCb25rZ8JC9m9vJ+9/5/6n5kJv9qbmwutmb+/m/+f+fv735//v/n/3735+9/fn/vb29vZv9n//f+f///9vfub+/////2////7//vb//AJDpv5vfnpvL6byw+prbD58NDw8JvLmpn58Lyampn/nb/9udv9v8nL3pyb6dqf/Zv5/5/fv/+f/f//vfvbvfm9vb2//by9n7/7+9/5v///m939//n9vf/7///////5//kOkA0PCwvb29vLn5n72tufuambmtqfDakLCfmtvZ/5+/+Z2//5/5qdqdv8n735v/+fm/v5/b//+//5/72927/bn739m/mb+f/9/7/////5n7v/vb///7/////////5v/wJCam5+fmtq/m9qa+fvby/kNvLybnwm5y9n5rZsL+9vb2fvf+f/Qnam+mZv5+f/bn7/f/f+9vb3/+f+f+fv98J/Z+5/9n/n///n//////5//35//37+f//////+/+9/78ArAntran5vQnp+fnpywvby5Cwnw8PDakLC8mw2f3b/9m9+//9vwsNvZvL28v5+9+9+9v5+f//vf///9v/mfn5n/mfkL+f+f+f/b//+/+f+f+/+fv////////////5/f8JCam5ub2vC/+byw+fuf2/vL29qZuZsJ+cmbybqb+5/7+b35/7/5y7y+n5rb2/n737372/35+f/5+9//+f+9vbCb/b29v5/5+9vf////+5/5/////9v//////////5//+gAJytranb2QvLn5vw8LD/mQkLnLy8D5C5vpmtn/2f/9/9v/+5/QCcmZ8J+fvfvb+fv9/5+//72//fv73/n/+9n5m8vb2fmf/b/7/72/n/+//5/9v//9+//////7/7/7/Qngmb29upr/ufC8sPn9ub2p65ywm5uQ8PCZ6Zvbm9/7n5/b/f/wvbD/C/D5n72/29/bvb/9uf///7/f+/n9vZ8J/bn52/n/2/2/////+fv9+/+//9v///////v/+9+f/wAJqemp+fn5Dwvbn56an/nJnJqZ8NDLmQvLkPn/n7/9+9v/n5nwkPsJ+duf+9vfv7+9+9mf/9vfn9v739+//729qcn5qdvb/b////+9v/373//b/7///////////b/5/wCQy5+enp8L+fmtvpu96euaC9npC5ucsPma2wm9+f/7373/+/+fDZ+fnr25+f+9n9v73/+9vf/7+/3/+/n5+9vb27kPn5+9v9v///////v/v5///f/7////////+//b/5oKkPC5+an9ra2w282pv/nJ0LCQ+ekLnQsNCZ//Cfv/+fm/3wnwmpD5+ZvLn737+b/f+9vb+/m9/9v5/f+//f/9vd+Z+fnb+f///7///5/9//+f+/////////////35/w0JD5vQv9+a25vLvbvby/kLC52tsJC9CwnakPm5n73///n/+Z8A29vakP29/5+fvf29vf//29vfvb+9u/n9m/v5+auf35+/373///////v7////v/v////7//+/+/+9v/AAmw8P+bC/mt6b2py8vb6cvLCQnbwL0PmpqZ/f+f//vb2f/Ln5qQ+b+bn5ufv5/b+//7/5vfv72/n/35+b+f2/n535ub35+fv////73739v9v/29//////+////wvb/8Cay9ubnp/Q+bmtvfufm9mpma2pqZsJqQDZ0Jv5+b+9/9sL/Z8A29vJ/Quf29vb+9vb29vf+9/fnf+b/5/9vb+fvbC9n5vbn5+///n/+f+/37/b/7/b/7///f/7/8mdv/4JCby8v5q/np+amp8Ly7+Q6dCckOna2puaAL/5/Zn/v7/Zm/AACem5mtnrvf+fn9v/vf+/37+/+/n9vb+bn52/29/by9+/29///7/5v/n/u9v/n///+////7////Cb/9CQran5sPnw+fD5/5rbn/DLmamwv5sJmcnJuZ/5+b/73///D5AMm9vfD5vZz7n727/b2/n5+9vbn5+fv/n9+fufm9uZ+fmdv/v//9+f/5/5/f2p/b+f/f/5/////wCd/w8A25+a35+fmpsPkL2w+duQvpwNkJC8sLC8AJv5/Qvf+f+9+fCQCa2pufn7uf2fvf2//9+/+fn9+fn5+f+/v529vJvLn5+/+Z//v7n72fmtqbn5+9v7+///v/+/v/Cb/wCpqfC9sPDw+enw+9rby7y9Cbmg+a0JycmbkJ/9v5m735/5vwAACZn929qd+b+f27+fm72b2tsLD56/n5vb2/nw+8vfnb35//v//9vfv8+b39ufn729/9v//////wCZ/w0Anp/L+bv5vLCbnp8Ln9sAvJyZC9qbmprQ0Jv5/b39+/8L/QDpAPmanwn7n9v/vfv7/fv9vb29+b2Z2/29vf+fmfm5+9ufvf//8L/56b29ub2/n5/7/7//v///+/CQ/wAJ6bm9rw2/y9vL37n9qbyb2bCwvQkNrQkJqQ/9v9m/v9+d8AkA6bz725+f27/bn52f27nan5+fm9uesJm/29ufn5v9rb3/n7//2fyb2fm9v/////+/2/+f//v//8n/vwqem8vL2fvwubC9qw8Ln/vACw0Nmp8LkJy9AJv/n56f//2/sAAJANudvPnpvb29+fv5vJ+9ufvb/73529rZr7/b28nb29vb/5v/rbufn5vb35vb///7///7/////wuf/ckJvb25+py9va0L29va29uZrbCw+QkNqakLkPmf+fmf/7n9rQAOCa2r25+fn5/7+dvfm/Db29v9vfvb+b29mdu9rbm9vb29vf//kN+9vZ/9v/2Qmp//+ZCfn////60L+p6a2tran/uemtsNra29rfngmQ0JAPC5nJC8CQv/mf27298L0AAJAJudqfn72/29+/m68Nuby9vb2w29mdvbv5/b296b2/vb/7/wn7/a2////ZC9vfvQAAvb+////wC/rakNm/m98L3pvan5ufmvm/AJvLCw25DQ8LyZsLnfn/mcvfm9oAAACd7bn5rZ+9u/v5vZmbnpm8n/n9v5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kAAKDQCp/pv/+Z+frb+Z//AAkAAJC/m5n5//v/vf////n///+/+9/7//n5///7//v///////////vaCvvLywoAAAkJyQ2pyeCckNCbyQnpnw8JsJkJCQkOkAAAAAAAAAAACQybmduZ6bkPn5/bCfvL/Qnp/b35vf+9v//////7////3///////+f///9v9/f/7////+//7//8JvZyw8MAAAAAAAAAAAAkAAAAPAACQAAkAAAAAAACQAAAACQCQAAAJAAkA8L3/n9+b8Pm/2tn5v/mduf+9////+9///73//5//+//9///7////+/2/+/////////////3gD6/QmpAAAAAAAAAAAAAAAAAA8AAAAAAAAAAAAAAADwAAAAAAAAkAAAAJDQsJ+5rZ29+b27+f+f+//5n73735//v/n//////7////v//9/5/b/b////////////v///uQCQvp7eAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAkADAAAAADQAAAAC8Cb2fvf2an73tvfn/n5/b2///+/+/+f////////+f//////2///////////////////////nLAJ8Lmp6cAAAAAAAAAAAAAAAJ4AAAAAAAAAAAAAAAAAmgAAAJAAAMAAkAsAmvDbC9+9ub/5/5+/+/vf+Zvf/9v/2///+/2///+f/5//v///v//////////////////7ywALy97fAAAAAAAAAAAAAAAAAOmgkAAAAAAAAAAAAADAAAkAAAAAqQAJDJANCZ25/bvL/9vbm9vfn9v5//+9v////7//3///n///v/+/3/+9////////////////////vACfnwsLywAAAAAAAAAAAAAAALwAoAAAAAAAAAAAAAkACQAAAAAAAAAAAK0L0L8Pm8n5mfn/2/+9+/3/vb3//b/b///b+/+/+///3/3/+///v/v////////////////9qQAAvp8J8MAAAAAAAAAAAAAAAMsAAAAAAAAAAAAAAAAAAAAAkAAJwAkACQkAC8m9rb+f/t+9v9vb/b+/3/+/+/+/2////f//n/v5+/v/v/n//5//n/v////////////78AkLybwLwLAAAAAAAAAAAAAAALwAAAAAALAAAAAAAAAMAAwAAAAAAAAAAA+skJvJ29n9ubvb37//v/39v7/9//3///n///vb/9///////b//vb///9////////////+9AJAP2sC/C9AAAAAAAAAAAAAAAMsAmgwAAAAAAAAAAJ4JAAkAAAAAkAAAAACfCcm6m/sL3/2/ufm9/b+///3737////+/+9////////29v//Z///7//2////////////a8OCa+fAPDa4AAAAAAAAAAAAAALwAAAkAAAwA4AoAAAkACQAAAAAAAADQAJALkLyfnJ/b+b+d/9+/v9/b+fv/v/+fvb/9/7/9v/v//b////m/mdv9+/v////////////5CQCfAK2/C9AAAAAAAAAAAAAAAOmgAAoAAAsAkAkAAAAAAAAAAAAAAJCgCQAJ6QuQ+9qfn9n7+b/f2/v/n//b35////3/vf/////b+/+/+f3pn7+fv/35//////////+emgkNsNDwv+AAAAAAAAAAAAAAALwAAAAAAAAAAAAAAAAAAMAAAAAAAACQAA0Am8kPkJ/bn7+/2/2/v/2///n/v/+9vfv7//+///v//9//nwCZ6Z/5/9u//7////////vwvA8KAL6bzQAAAAAAAAAAAAAAANoAoJAAAACsoAAACQAACQAAAAAAAAAMCQC8kLyQv5C9v5/b/fv5/b/9vb+//b3/+//9/7///9///7+9CQufmfn/+b/Zmcm5n//////PCQAJDQnAvpAAAAAAAAAAAAAAAOnAAAAAAACQAMoAAAAAAAAAAAAAAAAJAKCa3Ju9nLme2fn9vb/fv/n////5//vb/5+/v9/b+b/5+f/JkJnwm/2/n/m/6QAPvL////+fAJD8C/C88A8AAAAAAAAAAAAAAPCgAACgAAAACwAAkAAAAAAAAAAACQAAAJwJqQnAufD5v5v5+/29/b/729v/+///3//f/b//3/+///CwD78J/fvZ8J/wkLnZCZ////mgvAqQvACbC8AAAAAAAAAAAAAAAKyQAAAAAAAOAAAAAAAAAAAAAAAAAAAACQAAnLybnL25/b/fv9v7+/29v//fvf+f+/+////7/9/wsAkJudC7/72bCfkJCQygD/////D5yQnLDwmsnQwAAAAAAAAAAAAAANoAwAAAAJoJDgAAAAAAAAAAAAAAAAkJAAvQqQucucvZ+8m9/b29vfv/35+//7/7/5//2//9/7n52ZAMnwnfnQsJ+9rQvAkAm/////kAoJoMkLybCgAAAAAAAAAA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AAAAAAAACcAAAAAAAAAJAAAAAAAAAAAAAAAACQqQkLyQAAAAAAAAAAAAAAAAAAAAAAAAAACQypAAANCQuQDpAACQvJAJDADQAAAAAAAAqaAAAAAAAAAAAPAPCgAAAAAAAAAAAAAACgAACgkAAAAAAAAAAAAAAAAAAJAAAA0ADQC8kAAAAAAAAAAAAAAAAAAAAAAAAAAAkAAAkAAKwA0AAArAAAAMqQoAAAAAAAAKAMAAAAkAAAAAAA8AAAAAAAAACgAAAAAAAACQCcALAAAAAAAAAAAAAAAAAACQAJAAkAkAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAyQwACQkLAAvAkKCaCakAkAAAALAACwywoAAAoAAAAAAPCwqQAAAAAAAJCgAAAAAJoAAAAAkJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJAAAAvArAkACaAJAADAAPAAAAAAoAAJoJAAAAAAAAAAALwAAMAMAJALAKAAALAAAAAAAAkAAAD+AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQAAAAAJAJAADLwJwAnAkACQAAAAAAAADgmsoAAAAAAAAAAPqQygsAkACgAAAAAAAAAAAMkKwAAAAMANCQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAkACQAAAAAAAAAAkJqQAAAACgALwAAAAAoJAACQ4JAAAAAAAAAAAJwKkAAKAKAAAAAAAAAAAACQAJANoAkAAAAAAJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJAAAAkA6QAAAKwAAAkAAAAJAAAAAAAAAKAJoKmsAAAAAAAAAAAOvAAAAAAAkAAAAAAAAAAAAAAAAAAAAAkAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJAAAMkJCwwAALAPAAnAAAAAAAkAAACcCaAAAAAAAAAAANqaAAAAAAoAAAAAAAAAAAAKAAsAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAkAAAAAAAAA2gAAAAkAoAkADLCwAAAAAAoAAACgrAAAAAAAAAAAAPDAAAAAAADAoAAAAACgAAAAAAAOkAywAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQwAAAAAAACQAJ6QAAoJwAAAsAAAAAAAAAAAAKAJCaAAAAAAAAAAANoAAAoAAJAJAAAAAAAAAAAAAACQAJAAkKwJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJAACQAAkJAACQAJwAAAAAAAAKAAAAkAoAAAAAAAAAAAAPANAACaAACgAAAAAAAAAAAAAAAAAAAAAJAAkAkAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQAAAAAAAAwKyQAAywAAAAAAAAAJAAAACgAAAAAACgAAAAAK8AoAAAyvAAAAAACgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACakAAAALAAAAAAAAAAAACgAKAJoACpwKAAAACgAPAAAAoJAAAAAAAAAAAKAAAAAAAAAACQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAkAkAAAAAAACQAAkADAAJAAkAAAAAAAAAAAAKAACQAAAADAoJDwALCcAAwAAJAKAAAAAAAJoAAAAAAACgAACwDAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQ0AAAAAAAAAAAAAAAAA4L2pCeCQC8AAAACgAAAAAAAAAAmgAAsKkAoAAAygAPAAAKAAAAAAAAAAAAAAAAAAAAAAAAmgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAkAAAAAnACQAAAAAAnAAA4AALwAAAAAAAAAAAAAAACgAAoAAADwwAAAsAAK0AAAAACwAAAAoAAAAAAAAAAAAAAAAJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQAAAAAAAJAAAAAAAAAJAJAJAAAAAAAAAAAAAAAAAAAAAACQqeALAAAADrwNoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACcAAAAAAAAAAAAAAAAAJCQC8oACaywAAAAAAAAAAAAAAAAAACgngwAmgAAAAqQoKkAAAAAAAAAAAAAAAAAAAAAAAAAAAoMCQCcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACcAAAAAAAK0AkAywkAAAAAAAAAAAAAAAAAAACQoLCwrAAAAJAPANoAAAAAAAAAAAAACgAAAAAAAAAAAACQoAAAkAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAkAAAAAAAAAAAqQAJyg8JCwAJAMAAAAAAAAAAAAAAAAAAoLCg0AAACQAAAK2gAPAAAAAAAAAAAAkKAAAAAAAAAKAAoJAAAPAKwLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACQAAmgAAAACQAAANAAsAAAAAAAAAAAAAAAAAkAwMvKCgAACgAAAAAPAPAAAAAAAAAAAADJAAkAAAAAAAAAAACgkACQAAycAAAAAAAAAAAAAAkAAAAJAAAACeAAAAkACQAA8ADJwKkLDAC8AAALwAAAAAAAAAAAAAAAAADKmpAJAJoLAAAAAACwAA8AAAAAAAAAALAArAoAAAAAAADaAKCQAAAAAJAAAAAAAAAAAACQAAAJDAAAoAAAAAkJAAAAAACQAJAACcAACwkAALDwAAAAAAAAAAAAAAAAAKCpAACgAAAAAACpAJoAoPAAAAAAAACgAACwCQAAoAAAoJoAyQDKALAAAAAAAAAAAAAAAAAACQAAkACQANAMkAAAAAAAAAAAkKCwAAkAAAAAkMkAAAAAAAAAAAAAAKAAAAkACgAACgAAAAAAoMAAAA8AAAAAAAANAAAMoMCgAAAAAAALCgAAAAALAAoJCg0AAACQAAAAAMAAAAAA0AAAAAAAAAAAkAAAAAAAkKwJwADbywAAAAAAAAAAAAAAAAAAmgCgAAAAAACgAAAACgvLAPAAAAAAAAAKAAAAkKkAAKAAAAAAAMsAAADAAJAACQAKAAAAAACQAJAAAAAAAACQAArQAAkAAA0A4JDa2pAACQ8AAAAAAAAAAAAAAACgAJAKAAAAAAAAAACQAA6akAAAAAAAAAAAAAngCgAAAAAAkAAAAACwywAACemgAAAADAAAAJAA0AAAmgDAAAAAAAAAAJAAvArLDwCgkAAAAAAAsAAAAAAAAAAAAAAAAAAAoAoAAAAAAAAAAAAMkKkMrJoAoPAAAAAAAKCQCcAACgAAoAkAoAAAAAAAAAAAmgAAqQAJAAAACpDgAACQwLAADwAAAAAAAAkAAJAAAAAAAACQAMsAAAAAAAAAAAAAAKCQAAAAAAAAAAAADAoAoACgmgCpAPAAAAAAAACgwAoAAACgAAAAAAAAAAAKAKngAMCwAAAAAAkKnACQANCpAAAJAAAAAAAAAAAAAACQAMkJAPANqQAAAAAAAAAAAAAAAADgAAAAAAAAAACsALCamtDaAAAAAPAAAAAACQAJoAkMCQAAAAoAAAAKkACQCQALywAAAACwAOAAAAAACwAAAJDgAAkAkACQkAAJAAwAkAAACQCwAAAAAAAAAAAAAAAAAAAAAAAAAAAAkJoAsAygwKCgAAAAoA8AAAAACgAAAAALDgAAAAAAAAAACgoAAA68AAAMsAAAkAAMsACgwACcAKCQAAAAAAAAAJAAAAkAAKngvAvAAAAAAAAAAAAAAAAACgkAAAAAAJqawOALDpoJCpAACwAAAPAAAADpAA2gAAAAAAkMAAAAAAAAAJAAAKkKmgCwALAAoJCwALyQkKAAsNAACcCcAAAAAAkAAAqQDQCQAAAAAAAAAAAAAAAAAAAAAACgAAAACsAAqwsMAAAKAAAAAAAAAA8JAAkAAKAAAAAAAAoJoAAAAAAAAAAAAJ6cAPAADACQwKwK2grKCQ2gwAAMCgAAALAAAAANCQAMoAAAAAAAAAAAAAAAAAAAAAAAAAAACgCwALDpwAywmgkAAAAAAAAAAPAAAKAArQAAAAAAAAAAAAAAAAAAAAAAAACgsAAAsACgmgC8ANCQygAJALCQkAkACQAJAPAKCgAJAAAAAAAAAAAAAAAAAACgAAAAAAAJAAAAsACaCwoAoAoAAAAKAAoAAAoAAAAAAAAAAAAAAAAAAAAAAKkAAAAAAAsLwKAAAAAAAJAAmgoKkAkAqcCgAMCgAAwOCwC8nAAAAAAAAAAAAAAAAAAAAAAAAAAAAAoAoJCgAJoAAAAAAAAAAAAAAAAAoPAAoAAJAAAAAAAAAAAAAAAAAAAAAAAAqQDAqckACeAAAA4KAAycCsCsAAAMCpDAAAqQnA8KAAoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKAJCgCpCgmgAAAAAAAJAAAAAPDwAMsACgAAAACsAAAAAAAAAAAAAAAAALCwCgoAoAkJCgkJDpoACQAAkKkLAAAAAJAKCwDwAADaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKAAAAAAAAAAAAAAAAoAAAAPAACaAKAJAAAAAAkAAAAAAAAAAAAAAKDAAA8AAAAACgCQoOAAALAKkAoAAAAAqQAAAAwOkACwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA8ArADJAAAAAAAAoAAAAAAAAAAJAAkAkAraAAAAAAsMvLypAAAAAAAJANoAAJAAmgAJCwAADAsACgAKAAALwAAAAAAAAAAAAAAAAAAAAAAAAACgAAAAAAAAAAAAAAAAAPAJCpCgAAoAAAAAAAAAAAAAAAAKAAoACpAAALAACwywCgmssAvAAACgCgAAAAAAAAAAAJAACwwAAADQAAAAmsAAAAAAAAAAAAAAAAAAAAoACpAAAAoAAAAAAAAAAAAAAK2gAAAA4JAAAAAAAAoAAACQ2prADAAAAAAAkAAJALALCaCQAAAACQAAAACQAAAAAAAKAOCpAKkAkNoAAAAAAAvAAAAAAAAAAAAAAAAAAAwAAAAAAAAAAAAAAAAAAAoAAPAAAAqQkMAKAJCgAAAAAKkKoMAJqQCaAAqaAACgAArQysngAAALAKCQCQoAAAAAAAkJCwkADwCgCgAAAAAKCQAAAAAAAAAAAAAAAAAACwkAAAAAoAAAAAAAAAAAAAAAAArAAAAAoKAAAKCQCQAACQypyaCaAKAAAAAACgkAqemgsJoAAAAAAMAA4AAAAAAAsMoMrArLAAAAAAAAAAAACgCgkAAAAAAAAAAAAAAJDAoAAAoAAAAAAAAAAAAAAAAAAPCaAAAAAADQAAAAoAAACpqQoAAAwAAACQDAAAAAAAAAAAAJoJoACamgAAAAAAAACQAJC8kA6QAAAAAAAAAAAAAAoMAAAAAAAAAAAAAKC8AAAAAAAAAAAAAAoAAAAAAAAPAAAAAAAJCgAAAAAKkAAMCtDwCwsAAACssKkKAAALDwALwAwAyaAADJCwALAAAACgmgAKCwCgAAAAAAAAAAAAAAAKAAAAAAAAAAAAAAAJ4AAAAAAAAAAAAAAAAAAAAAAA8AAAAAAKAAAAAAAAAKmpraAAAAAAAAAAAAAAAAAAAAAACwCwoAAAsKAACgAAAAAAAAsJwMvAAAAAAAAAAAAAAAAACgAAAAAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAoLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABBQAAAAAAAImtBf4="),
                            Address = this.Addresses[6],
                            Roles = new List<Role>(){this.Roles[1]},
                            Claims=new List<Claim>(),
                            SecurityStamp = "a55afdff-c923-40dd-91b0-9a7cdf0b5baa",
                            LastActivityDate=DateTime.UtcNow
                        },
                        new User()
                        {
                            Id = new Guid("f3f3a7be-1a99-c4e1-c830-08d1c03f3913"),
                            UserName = "Robert@aaa.com",
                            PasswordHash = "ADlfX1+zP7nNsHgdei/CbMQHM6g0fIYu2YAlrqIA6ULALmWBIDHebhWYLo8f//P4+g==",
                            TitleOfCourtesy = Civility.Dr,
                            Gender = Gender.Male,
                            PhoneNumber = "(206) 555-9482",
                            LastName = "King",
                            FirstName = "Robert",
                            BirthDate = DateTime.ParseExact("05/29/1960", "M/d/yyyy", (IFormatProvider)CultureInfo.InvariantCulture),
                            Email = "Robert@aaa.com",
                            Photo = new UTF8Encoding().GetBytes("FRwvAAIAAAANAA4AFAAhAP////9CaXRtYXAgSW1hZ2UAUGFpbnQuUGljdHVyZQABBQAAAgAAAAcAAABQQnJ1c2gAAAAAAAAAAAAgVAAAQk0WVAAAAAAAAHYAAAAoAAAAwAAAAN8AAAABAAQAAAAAAKBTAADODgAA2A4AAAAAAAAAAAAAAAAAAAAAgAAAgAAAAICAAIAAAACAAIAAgIAAAMDAwACAgIAAAAD/AAD/AAAA//8A/wAAAP8A/wD//wAA////AP7ezaz+/OreDs7Lzgzv7+z/78/u7e/v783rzv/vz+3vz+/s/e/8AAwKDAzg7f4Pzp/fy/n5/Pzvzw/AAAAO/ODODOD8vg8O3srLyuys7w/OD8ys6eD+7eDg4O7azsDO3vysrs4Mrt7s/Kz87e/g7e/s/P7f/v/8/u7O784O/t/t7/7f7+/pAAAMnpyt7+D8vfy9vQ/Pn5/97/yvAADAytysDp7KzPzsrK3s7e/PDuys7K7eDs7O2s/Pzt6s8P7w7vrO3K3v7Q7Lyt7u+u7e/u/P7v7+7+/v7ay88O/t4P7+/s/u/v/wDAzg7A7e+s/L28vf6f256ekO/8rAygDA78rM7OwOys4Pzt7LysDg7Qzt683g/PDp7v7g6eDeDsrO/fzMr87s/u/Ozs6ez8/vzp7v7e3v3v/+3t7O7+3+/v7/z/79797/AAAN6ezv7entrf2vnwnt+Zz57//KwJAMwOwOnKzpzw7A8ODs/P7PzuvKzOrOys7Oz8vPzs7s/O3t7v687LwPz8rw8Ozt7vz+/v7e/v7+/+7/6s78/O7/z+/P7v7v/v/vsMDg8A3rzp6f2tvc8Pma3rkND+/97KAArNrA7NrODsns7Pz+Dsvsrc7OvM6ezsrerOz6y+ye4Pzq3vDO/s7+6+/OztrK7er87ez+2s/v7t/t/OnuDt/u/t7+/e3+/+//AAAMDP782tnp7bz735y9mcnw/P3vvMAAzKz8DqzKzKzKysDg/OzLzq2szp7Onp7O3v7e/Mvs3uvt7/ysDO/v3szKwO7O3s/P/v/v7/7e//7+rt7s/v7v//6+3u/v/P788ADK7t68vJ6cva296anJzp4J0P78/poAys8A4Mytyt6t7e7ezg/uz87P4Ozg7Ozw7K3uz+7Prt7e/v/LysDO7+vt7wy8rv7+7w7e3s/v7+/e3K7az+/97+/P7//u/+3v+8AM36/L2tnL0P3L/fkKmcn8vLzvz+0ADKzsztrODgzKysDtr8rJ4Ong3srPysrO3v7p4Pnuz+7+7f/+/LwMDOzqzv7OzOzv3v7v7+/v3v7+78zs7/z+/t7t7s/97//v77wO7cvJyenQ/a+cva2cC9CQ0NkO6e/pAMvLwOwM7ODs7P4Ozs/s787OrO3g7Pzg7Onu3u7e8Pz/+v/t/v77ytDM4O3w+s/+78/Pzt7e/v/vDu8O/e/v7e/+//7+/v7e/8AMsLyenp6fCdnt2tvJDA/PDw4Nzt7wAMzsDgzgyc7Lysz8vLwPDKytzpysyeD8+t7P7Pzrzu/rAP7+7fz87e7KnM7uzP7O3v767+/v7/7f7azv/v/+/+/O/O/v78/v/v/OD8np6c28np6frfCakLkJDQmcr+7akA7w4M4MrODez8vuzs7s7s3s4M7Pruzg7O76y8787f+wAP/P/u/u/un87wwM/g7/7+3t4P7+/+/g7O3v7+/t/t7/7/78/+//z+/w0J6dD5rL0Pnp3p+ZycDa0LwJwM/vAM7PzgwOys6srO7Q7awPDa4OnqyswMvOz+3t7vrP/vDA4P7+z/z97e7vzuvODt7t7v7+/s/P7//+y87+//7+/v7P/vz/7e7+/vyvDw2tvPna28nw+engkJoNrQngDgz+sAz60ODAzA3t7w7vys7M7M7OzM/KzsysvPDu3s/O/+sADv/t/svuvv3svt7pwOz+/e/t7e7+/t7P7O/P78/P7e/+3+/+///8/trQ0PDa2Q8NDbwPCfCdoA0AkPCQnO/tAA/t7AysrOys7O0MrNrKysDw4ODsrKz87u/p4P7/vJDg8P7+7/7t7a7v7e7e/gzg/u3v7vz+/+/6zv/+/v/v7+/v7v/v7+/vvK2tDw3p2t+enw29n8nwnJCfDQkAzv8MrP7w4ODAzp7PDw7KzqztrM4Ozg7AzODg/Lz87+/6yg4OAPz8/O3+/t7ezp7+3vDs7/78re/v7/7PD+/v3v78/vz+//7e/P7ez8DQ8NvJ6eDZ8NvJ6Z8PC8AACwyQAM7/z+nvDAwODO2s7PDtrMyszg7ADMnt68/P784O/enpAAAAoP/vr+7ez++v7+3vrP6eDO/v3s7e3v/s797+/vz+/O/t7+/+/v/vypy8nw+fn58PDw28ng2Q0JsNDJCpAPzv/v7M/g4M4Oz8rKwOyg/KwMDs6+7KzODsys/97/+goAoAAP78/PDvDs7e3u/s/+z+/Kz+7r7+/+8P7+/f7e/t7/7//v3vz878sMnPDfnvD8vb2fDQ+fnpqcDQCakMAA7e/Py+DAzKzvDg3szgzOwMDv4MDMC8DgzL7/7+/qAAAAAAAP/+7v787+nu/t7Lzs/t6cDv/e3v/vzvz+/u/vz+/+3+7/7v7+/PD5653rz5358PDw8PnJ6cnKkKkAwJAM68/r7t4MoM6c4O4OAMysDg7AwODg7O7P/v7e/P8JAAAAAAAPz//e3u/O7eD+/+7+/v7//M7u/v7/7+/P7/7e/vz+/v3+/8/t4JCcnevdsPren9vb2Z6enw+ZyQDQkAAAzu/e3srAzgzqzAzA7KDA7ODKzs7e3tr+D8/v7wCgCgAAAAAPrP7+/p757O/O7e3trPzu+vDe7e/t7/7t/P7/z+/v7e/vz+3vvLytrd6839296enp7a0NCdDwsNAKAJAADc7+y+2sDPwMrODsDs7sDAysvLzg4O3t7+z8/rAKAAAAAAoPzw/+/P7O/pztrv7+/+/9787K3v/v78/+7//v7/7f7/7+/v/gCcmf2+nb8Prfn9+fm9+a2tsNDakNCQAAzq/K3s7AysrMDA4A4MDA6t7ezOyt7O7+/P/roKCgAAAAAAwP6QDv/+z/7e+u3t7e3s/u/+8M7v7/z+/v/+7e/O/u/+/e/P4J/Lz8vZ/+3/377fnvntCcvJDQ8JwAAAAADtzv6ekO7awKwOzezA6e/MrK2svOz63t7+rgAAAAoAAAAACvDwAA/v/s+uz87v7v7/z/7/7/DM/v/t78/t/v7/z//P/v7wycCcvb3v6fvfvf2+28/b3p2a29DwkJDAAADOvPzs7AwMDM7PDgytzgy+3s7Oztrt6+2vyaCgoAAKALAKkL4KAAz+//z+/P3s8O/v/t78/t6sz/7+//7+/t7+/v7+/t7vmpy97e29/9/t/p/b/b2tuenNra0PDKkJAAAM4O8PD8rKygygwODuD+zK4PDp4Oz+zu/KoMkACgAAAAoAoPCQAAAN/v78r+r+7+3v7+/v7+/Q7+/t7+/vzv/P7+/vz+/QDQ/L2/vfvP+////969+fz5+p0NrQmQAAAAAAz+D87KwMDMrMrOzQ7A/tz87ez8vA/86pwKCgAAAACgCaCvCgAAAP7/7e/8/PD8/v3v/Pz+/+//z+/vz+/+7+/P/P76kOnLy9797////fvfvPvenp+fDdrb0J8ACQAAAM4M/OrQysrKzK3p4O2s4M6s4ODg7P7KkAC8AAAAAAAACgkP8MAJAAnv/+zv7+/u/v78/v7f7v/u//7f7e/t/v/t7+/PwJ6f3/n/3+3////9+/29vfDw2wnpy8CtDAkAAKz+4PzgwMzMreDOzg7Lz6zLzPzs/vCwoKAKkAAAAAAAAAoP6wmgCgAAr//s/Pz/7e/v7+/v3v/e/v/u/vz+/e/+/t7wvJDw8P/fv////////frfy9+fvP2enb2QkAAAAMDJ7w6eDK8Pys4PDtrODOnsrgz+nqygkArAoAAAAAAACgAP7aAACQAA7P7e+u/s/u3v7f7+7+/v79797//v7/7+3v4Jye/P3/6//f/9/9/7y/29va2tC5rJrQDw6QAAAA4Ozs/MDsysrNrM7Azg7A7K3O/p6QAAoJAKALCgoAoKAAAPmgAJAAAAAO//7e3v/v/t7+3v//z//v7+/v7+/+3v7wkND52///397//////f/9ve2tvZ/A2f2t+QkAkAAMwOD8rKz8rO3KwOAM4MwOyt7rywoKkAAACgmgAAAAAAAAAL6QkAoAAAAA7v/v7+/87+8O78/v/t7+/+/+/e/v78/py8vP798P///////7/7+f65vbyemfnpDwmtDQAAAMrPyt78rA3gys7A7ODvDp7Oz9oAAACtAOAAoKCgAKDg8LAPCgCgkAAAAAAM/t/vz//P797+/+/+//z/7/7/7//v7aDQ+f36/////9///9/9/5/e2tv56Q+e2fyQsLAAAAwM/KwPysrP7ADsDg0M7Oz/vg8KAA4K8AmgAAAKAAAKAAAPkACQAAAAAAAKz+7e/v7+3u/P/t/v/u/+/+/v/P7+0A2tz8v9/9//////3////e+fn5yenp0JrQvenAkAAADuDt78rezgwOwKwOzsD+sAwPoAAK38nr4KCwoAAAAACgoAAJAAAAAAAAAADv/+/+3+/vD+//7/7//v/t//7+/ekNrb///////9///////5+/n56enpmdqe2bwJkJAAAA7Az8rK3gwMDsDszw4O/pAACgAACsCgoAAJoKAAoAAAAACfAAAAAAAAAAAAAA7//v7v/t7v7+/v/t7+/+7+/t7gDp3t69////////////3/398Pn5+ezwnJvNvby8kAAAwP4Oz84M4ODKwNrOz+kAAAAAAAAAoADg8KAACgAAAAAAoKsAAAAAAAAAAAAACs///87+3s///+/+//7//t/+35yen73//f/9//////+/+++//b2tCZkPC8Cw2tkJqQAADA7LyvysDM4M7s7P/LAAAAAAAAAAAAAACgugAArAAAAAANAAAAAAAAAAAAAAAKz+/v//7+/v7//v/v3v7+/v4A2t/P//////////////39/8v++f+e25zZ8PkLy8kAAADsnOz8DA4ODtDO+wAAAACgoAAAAAAACg6QAAoKwKAAAAAKAAAAAAAAAAAAAAAADv//7+3v/+//7/7/7///7akNre//////////////3//7/b/fn5npANqaDZD9nJAAAAzA7trKysDwzK77AAAAAAwAAAAAAAAAAAAKAKAAmgAAoAoJoAAAAAAAAAAAAAAAAADv///v7//v/v/v/v7+/pDa39v9/9////////////n9//n57e+fnwnJ2s+aC8uQAACtwOzwzKzMr88AAAAAAKCgAKAAAAAAoAoAoJCsoAAAAAAOkAAAAAAADAsKAAAAAAAO/+///+//7+/e/+/97wDQ+v3/////////////////+f//n58PCfC8mbDZyZwJAAwODa3srMrOz6kAAAAAAMCQoAAAAAAAAAAJAKyQy8oACpAL4AAAAADgCaAAAAAAAAAADv/v7//v///v/v7+8A2v3///////////////////v/Cf+fn5npnJ6cmtvKmQAAAMDs68DKz68AAAAAAAAArAAAAKAAAAAKCgAACgAAkKkAAPCQAKCg6csAAAAAAAAAAAye///+///v7/7//vCent//////////////////+f35//Dw/J6Z6anJrZCdngAADg7A/A3u2tAAAAAAAACgAKDgAAAAAAAAAAoAAAoAoAAAAPygAAAACgCgAAAAAAAAAAoAAO//7+///v/v7fAA3/////////////////////v/n5+9ufnwkNC8m8vaCZAAwMDOrO6ekAAAAAAAAAAKCsAAoAAAAAAACgCgoAAAAAAAAK8AAAAKAKAAAAAAAAAAAAAAAAz////v7+///qnLz/////////////////////2v+ena2pCfnpybyZCdvLAADAy83p6QAAAAAAAAAAAAAKCgAAAKAAoAAAAACg4AAJAAAP6aAAAAAAAAAAAAoAAAAAwKAAD+/v7///7+/5AN/////////9///////////7/5/p+5n58JCQsMmsvLCQkACsrOoKAAAAAAAAAAAACgqgAACgoACgAAAAoArAkKAAAAAPoAAAoKCgAAAACgAKAACgoMAADP////7+///Az+////////////////////n9+fmfnJ4NCa2tDZrZ2Q2tAADAzK0AAAAAAAAAAAAAAAAAAKAAAAAAAAAAAAAAoJAAAAAP8AAAAAAAoKAAAAAAAAAACgAKAM/+/v///vy5rf//////////////////+/+/vbD5C8mQvJCQsAkAvL2bAAwOD8oACgAAAKAAAAAACgoKAAAKCgoAoAAAAACgCgCgAAAP6wAAAAAAAAAAAAoAAAAAwKDAAAz//+/v/+8Az////////f//////////3/39r5+enby8m8vJ28m8CQrQkADAzg4AAAmgAACgoAAAAAAAAAAAAAAAAACgAAAAAAAAAAAPvAAAAAAACgAAAAAAoAAAoAygAJ7+////7/6Q/////////////////////7+/me2tvpnbnJ29rZoJDJ0PAAwA4NqaAPrJoAAAAKAAAAoAoACgAKCgAAAAAAAAAAAACgAP6wAAAAAAAAAAoAAAAAAADAsA4Az///7+/+kP//////////////////v/+9vJ79vfnb2t6fvJ+fyZ6QCpkMCsz6AAz6yayQoAoAAAAAAAAAAAAAAAoAAAAAAAAAAAoMCvAAAAAAAAAAoAAACgAAAACsDgCgDv/v//786c///////////f//////29vfn/n63w/w+bnw3+npnwkLycAADKwMoAoMvpCgygAAAAAAAKAAAAAAAAAKAAAAAAAAAAAKAP+wAAAAAAAAAAAKAAAAAAAKAODKCc//7///kP//////////+/////+f//C88P/fv/n//P2/vb3/n56QkLCQwM6wCgCgAKAJrLCgoAAAAAAKAAAAAAAACgCgAAoAAAAAoLAAAAAAAAAAAKAAwKAAAAAAypypyg7//+/rDv/////////9///9+9//kP/b//2/39/5+/vN//+8+fnbyQ0MAPkAAAAAAAmgAAAAAAAKAAAAAAAAAAAAAAAAAAAKAAAKAPAAAAAAAAAAAACgoAAAAKAAoOoMra3/7//8nP////////////3///rw//2//b//+/vf/f376f3/nr2pC8sLDsAAAAAAAAAACgALAAoAAAAAAAAAAAAAAAoAoAoAAKAAAK0AAACgAAAAAAAACgAAAMCgDADaAADP//77D//////////////7/5/fvb/9///f/f////v9/7+f/dufnQnJzLAAAKAADgrLAAoADpAAoAAAAKAAAAoACgDpCgAAAAAAAPraAKAAoAAAAAAAAAoKAADaAKyssAAM/v/+nP//////////v///2/+9//////////3///3739/5+/3pqfCampAAAAAAoOmssAAKAKAAAAAAoAAKAAAAAAAOAAAKAAoAAP+gAAAAAAAAAAAACpwAAKCgCgAAAKAA///tDv///////////fv7/9vf/f//////////37//+/+enw+f2w2tDQAKAAAKDLzpCgCgCgCgCgCgAAAAAADKAAygCgoAAAAAAPoAAAoAAAAAAAAKDACsCgAAAACgoAAA7/77Df////////////39////v///////////v9/9/fn//b2/mtuZywAACgAACsqaAAAAAAAMoAoAAAoAAAoAAAoAAAAACgAAAP+QoAAAAAAAAAAAoKAKAMAAAAAAAAAJz//8AP//////////////+f////////////////37+//b29vJ/bDakNAKAAAAAArAoAoAoACgDwAAoAAACgAACgAAoAAAAAAAAPygAAAAAAAKAAAAAAoAoKCgAAAAAKAAoN7/vP//////////+9v7//////////////////v/39v9vPn/D58NsJqQAAAKAACgAAAAAKAOAKCgAKAKAAoAwAAAAAAAAAAAAKsAAKAAAAAAAAoAAAAAAAwAAAAAAACgAO/+0P//////////3//f////////////////3//f/7/b/5+Z+fmbyfAAoKCgCgAAoAAArACgCgAA4ACgAAAKAAoAAAAAAAAAAPAKAAAAAKDgoAAAAAAAoKCgAAAAywAADN7/Dv/////////////////////////////////7+f2+nb2tvLy8uQnaAAAA4ACgAAoKypoKAAoKCgoACgAACgAAAAAAAAAAAA4MoAAAAMCsmgAAAAAAAAAAAKkKDA8Amg/v6e//////////////////////////////+/n9/5+dvw+fm9uZ2toJAAoKAKAAAAAADqAAoAAAAAAKAAAKAAAACgAACgAAALmgywAACg6aAAoKAAAAAKAAoAAJCwAKAKz//P///////////////////////////////f+/n5+9n5+8/a2vCZ2tCgAACssKCgCgAAoAAKCgoAoAAAAACgCgAAAAAAAAAOAArAoAAACgAKAAAAAACgAAAAAAoAoAAMvP68////////////v////////////////f/735+fDa+fnLm9vZvamQsAAKAAAAAAAAoKCgoAAAAKAAoAAAAAAAAA4KAAAAALAKwLAAAKAAoAAAAAAAAACgCQCgAAAAAKyv/P////////////////////////////+/n9+en5n5mcm5/L+a2pyekAoACgoKAKAAAAAAAKCgoAAAAAoAAAAAAACgAAAAAOAACsCwoACgDA4KAAAAAAAAAAAAAAAAoArc///////////////////////////////f+fvb2emfD5/cudC9vZsJ0JwAAAAAoAAKAKCgoAAACgAACgCgAAAAAKAAoAAAAJoAAKwAAAAACpAAAAAAAKAAAAAACgAAAACg7+///////////////////////////////5+fvZ8J0LC53r3a2tDwsKCwoAAACgoAAAAACgCgAAAAAAAAAAAKAACgAAAAAOAAAACgAAAKAMrKAAAADAAACgAAAAAAAAAAAP////////////////////////////+/2/n5mfnbmdnQudq9vbmZydAAAAoAAAAAAACgAAAAAAAAoKAAAAAAAAAAoAAAAJAACgAAoAAAAKAJAAAA4LAAAMoAAAoAAAAKDv/////////////////////////////9vZ2Q3wuQnakL0PnZ6fCenwoAAAAAoKAAAAAAAAAAAAAADAoAAAAAAKCgAAAAAOCgAAoAAACgrA8OywoAAOsACgwAoAAAAAAACc////////////////////////////372/n9udn5+ZnQnwnrn58JAJkAAAAAAAAAAAAAAAAAAAAACpAAAACgAAAAoAoAALAACgCgAKAKCgAKzpAAoMDpwJoMCgoKkKAAAK///////////////////////////7/f/f+f29+dn8uZyfmdrbn5+Q8KCgCgAACgCgAAAAAAAAAAAOCgAAAAAAAAAAAAAMoAAAAAoAAAAA6tqeAAAKAAoKwLDADAAAAACs///////////////////////////f//29n5/bnwuZnLkJy528+QkPCQAAAAoKAAAAAAoAAAAAAKAAAACgAAoAoKCgAAALAAAAAAAACgoKAA4AoAAACgDQCsALCgoACp4N///////////////////9////////25vb+fmw2Z0JCZC9uevfkPnwkKCgCgAACgoAAAAAAAAAAADgraAACgAAAAAAoAAOAAAAAAAAAACgoKCgCgAAAAoK0A4MAJAKAACu///////////////////7/////7/b/f2dn//fvpuQ2w0JyZy5/5CZ6QAAAAoKAAAKAAAKAAAAAAAAAAAAAAAAAOCgAAAJoAAKAAAAAAAACgAKAAAAAAAACgmg8AoACgCc/////////////////////7///9/9uZ////+9/977DZCQnpva2/npnpCgoAAACgoAAAAAAAAAAKAKygAAAAoACgDQoAoOkACgAACgAACgoAoACgoAAAAAoNrAAOAOkAoK//////////////////+fn9/9//vb3////////735+wAJCQ29v56fCQAAAAoAoAAAAAAAoAAAAAAAAAoAoAAAoMoKAAALAAAAAADJCgAAAKCgoAAAAACgAKALDpDgDK0P////////////////////////vZ3v//////+f/5656ZAACdvJ+fmQ2toAAAAKAAoAAAoAAAAAoArKCgAAAAAAAKDgDKAOAKAACgoKAAAAoAAACgoKAAAACwsAAMsJ6wrL/////////////////7+fn7352vv/+//73/+9ubnJnLAAAAmenp8PkJAAAKAACgAAAAAAAAAAAAAMAAAACgoAAAytqQoNsAAAAAytoKAACgoKAAAAAKAAoKCgAKysnLCs//////////////////++/f+/nf2//9v/v7mQ0NCQCQkAAAC5+f2w+fCgoACgAKAACgCgCsoAAACgysCgAAAAAArKygAOrKAAAAAAAAAKCQAACgoKCgkKAAAAAAAKCgAP///////////////////bn/kAnvvf+b2Q2cvZubkJ8JCQkAkND5udCQkAAAAAoACgAAAAAAAAoKAAoAsAAAAAAKAArJoPAAAKAACgoAAACgCgoACgAACgAAAACgCwkADw//////////////////m9+QkJD5n/n529vb25ydC9CQ0JqZAAuQ/amtqQoAoAAKAAAAoACgoKDAAADKwJoAoAAAAKAKAOvg4JoKAACgAAAAAAAKAACgoAAKAAAAAAoAAP/////////////////7/bD5AACfn5+fvb29vfv5/bnbm9nQ2Zy9m9nJygAAAKAAoACgAKAMAACgAAoADgygAKDKAAAAAPywDgCQAAAAAKAKAOAJ6aAACpoJCgAAsACwCs//////////////////uduZvZ29+f35////n52/menpya2poJCa2bC5kAoAAAAAAAAAAAAKCgAKCgAKAOraDAoA8AAAAPvOsPCgoAAAoACQDwvgCgCgsAAKAAsAAJAAAP//////////////////nbnL2/////////298PvQ+9ufududmZD5np2emwAAoAAAAAAAAACgAAoAAAAACgyg8KwOAKAAAPywDAqckAAAkACg8KwAsACQDgoACwAKAKAKD+/////////////////7mpy9////////+fv/vbyfnJnp3LDby8uQ+fmpwACgAAAAAAAAAAAACgAAAAAAAAqeDgmgoAAAAKsNqa0KygCgCpAADpCwAAoKCekAAAoAkAsJAP//////////////////nZvf//////////3529mwmemam52pkJyZDw2cuQAACgAAAAoAAAAAAKCgCgAAAAAAAKDJCgAAAN6gAAqQsAAAAAoAAKAAoAAA4A6woADwoACsvO////////////////+9sL0L3////////7+/va2ZoJCdCcva25vL2bC5DaAAAAoJAAAAAACgAAAAAAoKAKAKCcoOCQoAAKkAAAAKytoAoKwLAAAAAAAKCtAACa4OkKAAAP//////////////////+ZD//////////9/b29ucmQ8AnpkJkNCZD9vQ8JAAAAAKAMraAAAAAAAAAAwAAAAACgDwoAAAAPAAoACpCaAAANrwAAAAAAoJwKAKCsnrygCgr+////////////////vfmQ/5////////vb+9vb0LkJAJkJ6fD5uQ+QkPmQAKAKCgDpoAAArAAAoKAKAKAAAArA4AAAAAAJoAkAkAoAAAAKwKCaAAAACgsAoAAA4OqQAADP/////////////////7/5kPn//f/9+9+9nb2/vZ6QmeCQkJkJy9n5+ZDwkAAAAAAKyaCgAK2gkAAAoACQAAALCgCgAA4OmgCwAAkKkAAArJoACgAAAADgCaAKDt7rAAoP/////////////////9vfmZ+f+/+//72bm9/9v525yZDamen5kPkPD50LDwoAoKAAqgAAoAAKygoAysoAkAoAAAAAsOnrAAAAsAAAygAAkKAKAAoKCgqQ4AAAyg6emgAP//////////////////+/nwn739//n9v/3/vf+fvamtm9nJkJ6Z7b2em90AAKAACgAAoKAKCgCQAAoJAAoAAAAKAAwMrKCaDwAACtqQAAoAzw6aAAAJAOmgoAoOnsoOn//////////////////739+fkN/7/b////////n729nZvLCaCemfm5258NmpoAAAAAoKAACgAADgoKDKCpAMDqvJCgoKz/AAAJCgAKAAAAAAoPDgCgoKCwrJCQAAoLywyv//////////////////+/v5+an9v9/////////9/56a2b+Z253w/frenavQAAAAoKAAAKAAAACQAMC8nAALCcCgAADtrpoACssPDJCpAAALzv8PAAAAoAmgoKAAAArbnb///////////////////f+fn5mv2//////////73729vNnpDbn5udm9udy9sACgAAoAAACgAAoACgAKCssAoLyaAAAKz+kADazwmgrACQqcrw+gCgCwCgoAAACgAP29/9//////////////////////n5+dvf//////////+9va27+Z+8+f3r/b3pvaAKAACgAAoKAAoAAAoJoAwJDpAACgAAoMsLAKCssAoACQCsnK0PCcsMoAqQAAoLCQ//////////////////////////+f+9vb+9/////////7/fn529kPDZvLm92w+b3wsAAAoACgkAAAAKCpAAAKC+6Q8ACQAAAKDsoNAACgAAAKkAoLCg4ODrDpAKAAAAyt////////////////////////////3/n73//////////9+9vJ6en5+/29/bvfn9qfAAAAAKAA6emgAAAACgAADA/+mgAAAAAAAL2goKAAoAoAAJAACemtremgrJCgmgD/////////////////////////////+//fvf+f//////////n5uZ6fn5/bn96f8P2tqQAAAAoAAAAACgCgCQAACsDr6aAAAAAAAMoAAAAKAA0LCgqQAAAAoKAACwrQAA////////////////////////////////+/37//////////+fvbyfnw+em98Pn9v5vbAAAACgAKCgoKAAAAoAoAAJqckACQAACgCrAAoArAkKCwyckAoKCgAAAMrK0KDP//////2////////////////////////9///9/////////7372tnw+b29vfn5+byfya0KAAAACgAAAAAAAAAAAACgAAoJCgAKAArOkAAACgoJAAmg4ACQAACgCg8Prw8P/////////////////////////////////f+///////////+9vbCfn9vb3w+fn9v5n5rQoKAKAKAAAJAKAJAJAKkACwmgAKAAAAAPqwoKDgygsKAJCgAOkKAAAA7vywD//////////////////////////////////7////////////n/m9+fC9rfufn569nPqQmpCQoAoACgCgoACgCgoA6enKyaAAAACgoL0AAACesAAJCwCQoACgAAoKy8sMv//////7///////////////////////9/7//3////////////5/anp+f25z5+fnb+5n5CeDgAKAKAAAAwLCQCQCeAAoJoACgAAoAAPCpoKDgAJAAAAoKAKAACgAMvrDp7/n///ud/////////////////////////9//////////////+fC5+fn5ufub0Pn62c8JywsACgCgoAAKCwCsvAoAAKAKAAAAoAAAoKkAAAAKkAkAAAAAAAAKAACgAAAK3/////n7////////////////////////v/+f//2////////5/5+dCenpyQ2cuenZ6bnakAAKAOAAAKkJAACQmpCgoAAACgAAAACgCv6amgoACgAAkAAAAAAACgAKCgAA///5/72d/////////////////////7+f/b/5/7/9////////+fmp+Z+bn5C5CZqZnp6Z+aAAoAraCQoKCwoODgAAAAAAAAAAAAAKALkJAAAAoNqaAAAAAAAAAAAAAAoJ//uf39v/////////////////////////n/n/+f///////////7ydD5kJCQkNm8na29m8kAAACeCgoK0ADAkAkJoAAAAAAAAACgAACvCgAACgDawNAAAAAAAACgoACgAM/52fv7+f////////////////////+9+5+b2/n//7///////729mwuQyQ0LyQvJmtnQvJqaDKDgAAANqwqaytrKAKAAAAAAAAAACgoKkJoAAAoKmgsACgAAAAAAAKAAAP/5vd/9////+f//////////////////vby9vJ+fn9////////vbDZ0LkJvZm9ma2QsL2w0AsMoAoACgDLytrakAAAAAAACgAAoAAAANoAAAAAAAAAAKAACgAAAAAAAKAM//mvn///+//w///////////////72529uQm5D5+/+9v/////29sAkAnwmenL0JqZyQnbDwCgywAKAKAADKysoKAAAAAAAAAAAKAAoKkAkAAAAKAKAAAKAAAAoKAACgAP/7nZ+b3/+9sJ3/////////////////v5+fnJuQnJ/f/////7/5CZqZCZ8Jm5C9nLCfCQ0PDPrKAAAACgoKCgAACgAAAAoAAAAAAAAPAKAAAAAAAAAAoAAAAAAAypoAz//52bnf+9uekP7///////////+//5/5+f25+b0Jmbn7/f///9+Qnwye2fD56cvZCw2wnpCwoKAAoAAAAAAAAAoAAAAAAKAAAAAAAACg8JCgAAAAoKCgAKAAAAoKAAycv//7ucufn/35sJ//////////////n/v///v/n5m58Jy9v/////v5AJmZDpkJCZAAkJANCenAAACgAAAKAKAKAAAKCgAAoAAAoKCgCgALCgAAAAAAAAAKAAAACgAAoKCgz5//25kPCfvwkA3//////////////////9+enLyQmdvb3////5+fkACpkAAAAAkAAAkLAJCaCgAACgAAAAAACgAAAKAAAACgAAAAAAoOkAAAAAoKCgoACgCgAAoAAAAA+///+fmZn5+ZCc////////////+f///f//+fn5ufmpnp+f////+pAJDQAAAAAAAADJCQn5AAAAAAAAoKAAAAAAAAAAAAAKAAAKCgoAALAAoAAAAAAACgoAoAAAAKAKDfvd////mQ//nKkK3/////////+/n//5/725kJCQ0JCcufn/////nZCQAAAAkAAAwJCwDw0AAAAKAAoKAAAAAAoAoAAKAKAAAAoAAAAKAKAAAAAAAACgoACgAKCgAAAAoO2/////+5CQuZANv////////7+f+5mbAJAAAAAAkAkJDQ/////5+wkAkJAAAAAJCekJCQubAAAACgAACgoAAADpDgoAAAAAoACgoKAAANoAAAAAAKAACg4PAAAAAAAAAP/f///7+emQAAkA3////////9/5/b6dvQkAAAAACQsJC5n9////n56QAAnpCa28uQkAkNDAkAAAAKCgAAAAAAAKAAygAAAAAAAAAAoAAKAAAAAAAAAKAAAAoKAAAAAAAOn5//+wkJAJCQAND////////7//+9n72/vQkAsAvJCQmc+/////+ZkJCQAJy8kJAJCbywm5AAAAAAAKCgAACgoMCgoAoKAACgCgoAAKAAAAAAAAAAAACgoKAAAAAAAACt+f2/sNCQCQAACa//////////+fn/uc/9//udDZCQkJ6fvfv//bDw+akAkACQkJCcrACQnAAAAACgCgAAAAAAwAoAAAAAAKAAAAAKAACvAAAAAAAAAAAAAAAAAAAAAAAPvf/9mQAJAAAAAM3/////////////n5mfmf37mpCQkPnb2/35+/25DZAJCQkAmssJmZkNoJAAAAAKAAoAAKAACgAAAKAAAAAACgoAoKAKAAAAAAAAAAAAoAAAAAAAAAAA+52/CZkAAJAAAJr///////////+f+/mp8LCcmQCQ+Zv56fv/n5n/mtuQAJCQmQ28vK2wkAkAAAAAoAAKAAAKAKCgoACgoACgAAAAAAoPAAAAAAAAAAAAAAAAAAAAAAAPnb+ZngCakAAJCa3/////////////n//fn5+bCdvLmtCfn5+f8P8J+ZDakAAAAJCZCZAJAAAAAAAAAKAAAAoAAMAAAAAAAAAAoKCgAAAAAAAAAAAAAKAAAAAAAAAAAAAOm9nJ6Z+ZAAAAAM3//////////9///9v7+fn9vamZDQnwsPn/n/n/nw+ZCQAAAAAAAACQAAkAAAAAAACgCgAKygoKAKAAAAAAAAAAoAoKAAAAAAAAAAAAAAAAAAAAAAAN+em9vfnpkAAAAJr//////////7+9///f372pCQAAkPkNnbyf/5/56fnw2tAAAAAAAAAADLAAAAAAAAAAAAAAAAAAAACgoKAKAKCgCgyrAAAKAAAAAAAAAAAAAACgAAAA6ZkN+/mQAJAAAA2f//////////3629+7CQCQAJCQ2p6Q8Pv5/fvfn9rbCQmakAAAAAAAkJkAAAAAAAAAAKCgoKCgAAAAAAAAAAAAAAAMoAAAAAAAAAAAAAAAAAAAAAAA+97/vZAJAAAAAAD///////////+dvanQkAkAkAAACdn/n9/f+/37/72/29rQnJAACQAMCcAAAAAAAAAACgAAAAAACgAAoKAAoKAKCgoKAAAAAAAAAACgAAAAAAAAAAAACZmZCQkAAAAAAJD8///////////7kJAJ4JwPC8np///5//+/39v9+9vQvw+f2w0PngkJsKkAAAAAAAAAAAAAAAsAAAoKAAAAAACgAAAJ4AoAAAAACgAAAAAAAAAAAAAAAAAAkAAAAAAAAACf/////////////fn5nbvZ/b29+fn/3//b+/+/3////b3wvJqQCdDwDJAAAAAAAAAAAACgCgAKAAAAoKCgAKAAoKAKkAAKCgAKAAAAAAAAAAoAAAAAAAAAAAAAAAAAAAAJ/////////////////9/////////7/5////3/v9+fn9rfm9mfkLAJCQkAAAAAAAAAAAAAAAoACpoAAAAAoAoAAAAOoKAAAACgAAoKAAAAAAAAAJAAAAAAAAAAAACQAAAA2//////////////////////////f///9/b/9/7///725yanpDJCQAAAAAAAAAAAAAAAAoAAAoAAKCgoAAAAKCgALAACgAAoACgAAAAAAAKAAAAAAAAAAAAAAAAAAAAkJ///////////////////////////////7/////f+f29vQm9CQCwkACQAAAAAAAAAAAAAAAKCgAAoAAAAAAAoAAAoOAKAKCgAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAAD/////////////////////////////3/n/3/////vbCfCQkJCQALAAkAAAAAAAAAAAAAoACaCgAKCgoAAAAKAAAJoAAAAAoKAKCgAAAACwAAAACQAAAAAAAAAAAAAAAAnL3///////////////////////////////v/v/n/+dsJkJoMkJAAkAAAAAAAAAAAAAAAAKAAAKAAAAAKAAAAAAAOAAoAoKAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAJCf///////////////////////////fv/+f/f3//5mwkJ6QnbkACQCQAAAAAAAAAAAAAACgCgoACgoKAAAKAAAAALAAAAAAAKAAAAoKAAAAAAAAAAkAAAAAAAAAAAAAAAC8/////////////////////////////9///7/9+58Nn5kNqQAJDAkAkAAAAAAAAAAAAAAAAAAAoAAACgAAAAAAAAoAAKCgoACgoAAAmgsAAAAAAAAAAAAAAAAAAAAAAJDZ/////////////////////////////7//3/+/nQmbCakJ0JkAmpAAAAAAAAAAAAAAAAAKAKCgCgCgAAoAAAoAoPAAoAAAAAAAAKygAAAAAAAAAAAAAAAAAAAAAAAAkMkK2f////////////////////////////3/v/3/u5AAkNCamekACQCQAAAAAAAAAAAAAAAAAAAKAKAAoAAAoAAAAAoAAAAACgAAAACQoKAAAAANAAkAAAAAAAAAAAAAAJqdvv//////////////////////////2/+/3/v52Q2525C8mpAJCQkAAAAAAAAAAAAAAACgoAoACgAKAACgAAAA4PAACgoKAAAKAAoKCQAAAAkACQAAAACQAAAAAACQCQnanf////////////////////////+///3/+/35oNucuQDZkJCQAAAAAAAAAAAAAAAAAAAAAAAAoAoAAKAAAAoKkKsAAAAAAAoACgAACgkAkAAJAAAAkAAAAAAAAAAAnp6d6//////////////////////////////5/f+5nbyb2pmQqQAAkJAAAAAAAAAAAAAAAAAAoAoKCgAAAAAAoAAACsoKAAAAAAAAAAoKAKAAAAAAAJCQAAAAAAAAAAAMCQmpna3/////////////////////////////+9vwC9vwmQD5kJCQAAkAAAAAAAAAAAAAAACgAAAMAAoAoAoAAAAKALAACgoKAKAKAAAAAAAAAAAAkAAAAAAAAAAAAJAJAPDZ79//////////////////////////3/n///+Z2fCfnLkJrQkJCQAAAAAAAAAAAAAAAAAAoAAKCukAAADKAKAAAKAAAAAAAAAAAAsKCgAAkAAAAAAAAAAAkAAAAADa2QkPvb//////////////////////////+//72/menpn5qZDwkJAAAAAAAAAAAAAAAAAAAACgAADgzwAKCeCwAACgCvAAAAAAAAAACgAJAAkAAAAAAAAJAAAAAAkAAAAJALDw3t/////////////////////////////f/58Jm9qckJCQCaCQkAAAAAAAAAAAAAAAAAkKAKAL4PoMDg4JoAAAAAoAAAAAAAoKAKAKAKAAAAAAkAkAAAAAAAAAAAALCckPn73///////////////////////////v73/mw0L25vakJkJAAAAAAAAAAAAAAAAAAAADA8AAADg2prLygCgAAAPAACgCgAAAACgCgCgCQAAAJAAAAAAAAAACQAADQmpDQ/f////////////////////////////3/+9+cn5CckJyayQkJAAAAAAAAAAAAAAAAAACsoKCg8OoACgqaAAoKAKAAAAAAAKAKAAoJoJAAkAAAAJAAkAAAAAAAAAAAwAD7z////////////////////////////b/9vfsLmtvbm5CQkAAAAAAAAAAAAAAAAAAAAMrL4JDACpAAoAAAAKAACpAKAAAAAAAAoAAKygAAAJAAkAAAAAAAAAAAAJAJCQnJ8P////////////////////////////+//72Q2QkJDakJAJCQAAAAAAAAAAAAAAAAAKng/OCwrKCgAACgoAAKAOoACgoKAAoAAAAAkKkAAAkMAAAAAAAAAAAAkAAAAMsN//////////////////////////////39vfv5rby5kJywkAAAAAAAAAAAAAAAAAAAAACgqa7LAAwAoAAACgAAALAAAAAAAAAAAACgoAAAAAAJCQAAAAAAAAAAAAAACQDa/f//////////////////////////v//7+9+fkJmcqQmQkJAAAAAAAAAAAAAAAAAAAKCQzumgCgoKAAoKCQoJCgAKCgAAAAAAAAAAAAAAAAAAAAAAAAkAAAAAAAAJAA2v2v///////////////////////////9v9/fD5DbyQnakAAAAJAAAAAAAAAAAAAAAAAMCsqpoKAKwAAAAAwKkKAOAAAAoACgAAAAAAAKAAAAAAAAAJAAAAAACQCQkAAACd///////////////////////////9////v5+9uQmpAJAJAAAAAAAAAAAAAAAAAAAMoKAAAAAAoAqaCaAKnpoAoLAAAAAAAAAAAAAKAAAAAAAACQAAAAAAAAAAAAAAkJDK3///////////////////////////v729+/298PkJsAkACQAAAAAAAAAAAAAAAAAAzpoAvKCgCgwMoAAAoOnpAMoAAAAKAAAACgAAAAAAAAAJAAAAAAAAAAAAkACQAAC9r/////////////////////////+//f//vZvbCZCcCQAJAAAACQAAAAAAAAAAAAAJoKwKAAAAoAoKysqQDtqaCqAAoA4JCgAAAAoACgAAAAAAAAAAAAAACQAAAJAAAJDQ/f////////////////////////////n7368PnwsAkAkAAAAAAAAAAAAAAAAAAAAKDAmgoKkKAKCtCwAKywoAkLAAAACqAAoAAAAAAAAAAAAAkAAAAAAAAAAAAAAJAACt/////////////////////////73/+f/9udmZCdkJCQCQAAAAAAAJAAAAAAAAAAAMoOAAAAoAoAAArJoJDpyaCsoAAKAA6QAAAAAAAKAJAAAACQAAAAAAAACQAAAACQCQnt/////////////////////////5/72//7/58JCwAAAAAAAJAJAAAAkAAAAAAACQCwqQoACpCgoACsCgAKAAkLAAAACsCgAAAAAKAAAKAAAJDAkJCQAAAAAAAAAAAAkN6////////////////////////////5/56fCama0JAJAACQCQAAAAAAAAAAAAAAkA4MAKAODKAAAAoAsA4OmgoACgAArAoAoACgCQCgAAkAAAALyQwACQkAAAAAAJCpCtvf/////////////////////7//+9vf+fn529kJCQkACQAAAAAAAAAAAAAAAAAACskKmsCwCgAKAKCawK2toAAOAAoAAKmgAKkAoKkAAAAAAACQkAkJAAAAAAAAAAkJyQ3//////////////////////9/9//+9v5+akJywkAAJAAAAAAkAkAAAAAAAAAAJyaDgAArK4JoAAJygCsrKDpoLAAAKAMAKDAoAAAoKAACQAAAAAAAAAAAAAAAAAADACQvJ///////////////////////7+fvb2+n5+bCQCQkAAAAACQAAAAkAAAAAAAAAAAAJoAAAngDgmgDKwOC8sAAOCgoAygoACgAKCgAAAAAAAAwJAAAAkAAAAAAACQCQsMn//b////////////////////////28vZkJCQkAkAAAkJAAnAkAAAAAAAAAAACQsKCgALDg4LAAoMqQsKnKAKy6AMAAoAAAAAoAAAAAAAAAAAkMqQAAAJAAAAAAAAAAwLnp/////////////////7////+f2wvbkJqQkAkJAAkAAAAAAL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AAAAkOAKAKCgqeCtDpDwkJAK28v72trZ8NqfD5/bDw8J6b+Z/ay56esLy8raDskOALwLAAAAAAAKAKAKCg/v/vy9oKCgCgCsrp7+77AAkAoAoAAKAAALCgAACgAKAKAKAAAArAvJCgAA8K0KCQ8Nrc/5DbycrZ+en73wvPC8+ZDfnwkPCtvgug+toJ4MsKrJrAoMCgoArKAADAAAwO7///vqysDAoMrKz+/v/8AKCgAAAAoACgCgAACgoAAAAAAAAAAKwL4KAAAKAPCpAODLy6kJ6ekLmanr28mp29vfma25qQnprbALDbCQqeDrDpwKAKAAoAAOAADKCgCgCs/v7/7wkAoKzrz+/+///r4AAAAACgAAAAAAAAAACQoAkAAACgoAmsCQoAoAoAAMoAmgsNDwkJuQ2tudrb+cvLy5/9vL2tqa2s68ussK2gsMsAqQ4A2gDAoAAAoAAKDKDK7///8A4ODsvO7+/v7+/wsLCgCgAAoKDaCgAAAAAAAKCgAAAAAAALCgAACQAKCwCaAACgAKDgDJCQCQnpy/m9vaCe+8sPvLCanLyaDwDwywywDgCwAKCgCgCgCgAMAACs/v/+/+Dp6e7/7/////77wAAAAACgCQCgAAoAAACgCQAACgAJCgoMAAoLygCwAAoACgAAsJCQsKAAngsJsJ6emp+prbz7y8vp7+vp6/+/v/vpqQrAoMAADArADAoKCgDLz///+svO7v/v/+/v/v/+CgoKAKAACgvAsAAAAKAAygAAAAoKAMAKCpwAAMrAywAAAAoKAAoKAJCpoJwOAPCwvLCby++/v7+e+trb//////+5oKAKAAoKCgAKCgAAAMoO7+/+/v7v//7+/v//7/77AAkAAAAKAACgAAAAAAALAAoAAAAACwoJAAoKCgmpoOmgAAAJCgkAAKAAAKCwvK2tq8usv7////v73+/v////////kMqQygAMAAoAAKCsCgDg//7//+/+/v/////v///8sKCpoAoAAAAAoKAKAKAACwCaAAAAAAmgoAANDawOkAAJoJoACQoAsAoKCQ4PCwsLywCa3///////r8v////////7+pCgALCgoMAOAMAKAA4O7////v7//+/+/+//7+//CgAAALAKCgCpAAAAAAysoAoACgCgoAAAAKCgqgsADpoAAAAKCgkAAAkJDgmgra8PsLnrr/////////7/////////mgrAsMAAAKCgCgoADgvO/v/////+///v/v/+//66AJoACgAAAAAAoACgAAoLDK2gAAAJAKAAsAkMnJCpqQAKAKCQCQoAAKDgqQrJ8PC7y9q9/7////v//6/////////7qckKAKAKCgDAoADA4Ozv///+/v7//v/////r+svPCgAKAACgAAoAAKAACg0MqQDaAAAAAACgAKygoKAACgqQCQoLygCgoAAJCpCaCwvpvr2vv///v//7/vD5+///////mgoA4AoAwACgDKyvD+//7//////+//7+/vr8z6yqkAoACgAAoAALAAAKAAoJAKAAsACgoAAACgkAAAsAAAwKAAAACeCQAAsK0KCpytC+n7/56fv7+/v///+vv7/////76QDpCgDgoOAOCsvO7/7///////7//v//762roAAPCgAAAAoAAAAAAACwAKAKCpCgAKAAAACgqcoLCwAKCgCgCgCwoAmgoKDLCpAAqavb//v7+/v//7+//v7Ly//////7mgsKANoAAADp7P7//v/+/////v/+//6vC8rAwOCqAACgoAAAAKCgCgAAAAAAAAAJAJAAoLAAAKAAAAoAkAqQkJAAkAoACQCwkACpAP2vv7+////7+///7/C/v//////7ywwAygCQ6e6e7+/v7/7//v////vv/srwDgAKCgDPAKAACgAKAAAAAKygsAoAAACgCgAAAAqaCpqaCgAKypAKCgoKCpCpoKAAqakAuav////7/7+/v7+//+/a/7/////6kAoKkK4ODg/v///////v/////v76yrwOoOCsDKygsACgAAoAAACQAAkAAAAKAKAAAAmgAAAAAAAAAKkAAOAAAACQAKAAAJCgkA6eDp+/+/v/v////////76/D//////78LDQrJDp7/7+/v/v/v///////+8PrAoAwAwKysrPCgoKCgAACgoKCgoKCgoAAAAKCgoACgoKCgoKCwoLCwsLCwsKmgsKmgqQoPm7m////////7+/v7+//v/L+///////Cw4K2u7+/v//////7/7+/////p7g4ODgoODg4OyqAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKn7////////////////////6/v//////7msvP7////////////////////+4ODg4ODg4ODgoAAAAAAAAAAAAAABBQAAAAAAAHCtBf4="),
                            Address = this.Addresses[6],
                            Roles = new List<Role>(){this.Roles[1]},
                            Claims = new List<Claim>(),
                            SecurityStamp = "a55afdff-c923-40dd-91b0-9a7cdf0b5baa" ,
                            LastActivityDate=DateTime.UtcNow
                        },
                    };
                }
                return this._users;
            }
            set
            {
                this._users = value;
            }
        }

        public List<Role> Roles
        {
            get
            {
                if (this._roles == null)
                {
                    this._roles = new List<Role>()
                    {
                         new Role()
                         {
                             Id = Guid.NewGuid(),
                             Name = "Admin"
                         } ,
                         new Role()
                         {
                             Id = Guid.NewGuid(),
                             Name = "User"
                         }    

                    };
                }
                return this._roles;
            }
            set
            {
                this._roles = value;
            }
        }

        public List<Claim> Claims
        {
            get
            {
                if (this._claims == null)
                {
                    this._claims = new List<Claim>()
                    {
                         new Claim()
                         {
                             Id = Guid.NewGuid(),
                             ClaimType = "test",
                             ClaimValue = "test",
                             Description = "test",
                         }  
                    };
                }

                return this._claims;
            }
            set
            {
                this._claims = value;
            }
        }

        public List<Login> Logins
        {
            get
            {
                if (this._logins == null)
                {


                    this._logins = new List<Login>()
                    {
                         new Login()
                         {
                             Id = Guid.NewGuid(),
                             LoginProvider = "test",
                             ProviderKey = "test",
                             ProviderDisplayName = "test",
                         }  
                    };
                }

                return this._logins;
            }
            set
            {
                this._logins = value;
            }
        }

        public List<News> News
        {
            get
            {
                if (this._news == null)
                {

                    this._news = new List<News>()
                    {
                         new News()
                         {
                            Id = new Guid("b35369e3-ac21-c8aa-e553-08d1ca783d33"),
                            Title = "Phasellus scelerisque metus",
                            ImagePath = "news-thumb-1.jpg",
                            Summary = "Suspendisse purus felis, porttitor quis sollicitudin sit amet, elementum et tortor. Praesent lacinia magna in malesuada vestibulum. Pellentesque urna libero.",
                            Body = @"<p><iframe class='video-iframe' width='750' height='422' src='//www.youtube.com/embed/rYwTA5RA9eU?rel=0&amp;wmode=transparent' frameborder='0' allowfullscreen=''></iframe></p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p><p>    Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit,    accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><ul class='custom-list-style'>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li></ul><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><p class='box'>    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a></p>",
                            Events =this.Events.Take(3).ToList() 
                         },

                         new News()
                         {
                            Id = new Guid("06a7d134-d367-c2b8-f8a0-08d1cc07c093"),
                            Title = "Morbi at vestibulum turpis",
                            ImagePath = "news-thumb-2.jpg",
                            Summary = "Nam feugiat erat vel neque mollis, non vulputate erat aliquet. Maecenas ac leo porttitor, semper risus condimentum, cursus elit. Vivamus vitae libero tellus",
                            Body = @"<p class='featured-image'><img class='img-responsive' src='http://localhost/LMS/App_JS/compounents/collegeGreen/images/news-1.jpg' alt=''></p>    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p>    <p>Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit, accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <ul class='custom-list-style'>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    </ul>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <p class='box'>        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a>    </p>",
                            Events =this.Events.Take(3).ToList() 
                         }  ,
                         new News()
                         {
                            Id = new Guid("581db4c5-afaf-cc0c-f3a3-08d1cc07dd2f"),
                            Title = "Aliquam id iaculis urna",
                            ImagePath = "news-thumb-3.jpg",
                            Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam bibendum mauris eget sapien consectetur pellentesque. Proin elementum tristique euismod. ",
                            Body = @"<p><iframe class='video-iframe' width='750' height='422' src='//www.youtube.com/embed/rYwTA5RA9eU?rel=0&amp;wmode=transparent' frameborder='0' allowfullscreen=''></iframe></p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p><p>    Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit,    accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><ul class='custom-list-style'>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li></ul><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><p class='box'>    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a></p>",
                            Events =this.Events.Skip(2).Take(3).ToList() 
                         }  
                         ,
                         new News()
                         {
                            Id = new Guid("91ec4896-974f-cfc9-2d02-08d1ca7c9850"),
                            Title = "Phasus scelerisque metus bis",
                            ImagePath = "news-thumb-4.jpg",
                            Summary = "Suspendisse purus felis, porttitor quis sollicitudin sit amet, elementum et tortor. Praesent lacinia magna in malesuada vestibulum. Pellentesque urna libero.",
                            Body = @"<p class='featured-image'><img class='img-responsive' src='/LMS/App_JS/compounents/collegeGreen/images/news-1.jpg' alt=''></p>    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p>    <p>Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit, accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <ul class='custom-list-style'>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    </ul>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <p class='box'>        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a>    </p>",
                            Events =this.Events.Skip(3).Take(3).ToList() 
                         },
                         new News()
                         {
                            Id = new Guid("dcc9a7e5-71cd-cb77-953d-08d1cb3fd1b8"),
                            Title = "Morbi at vestibulum turpis",
                            ImagePath = "news-thumb-5.jpg",
                            Summary = "Suspendisse purus felis, porttitor quis sollicitudin sit amet, elementum et tortor. Praesent lacinia magna in malesuada vestibulum. Pellentesque urna libero.",
                            Body = @"<p><iframe class='video-iframe' width='750' height='422' src='//www.youtube.com/embed/rYwTA5RA9eU?rel=0&amp;wmode=transparent' frameborder='0' allowfullscreen=''></iframe></p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p><p>    Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit,    accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><ul class='custom-list-style'>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>    <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>    <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li></ul><p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p><p class='box'>    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a></p>",
                            Events =this.Events.Skip(4).Take(2).ToList() 
                         }, 
                         new News()
                         {
                            Id = new Guid("edc8b9d1-eb59-c66f-4c6c-08d1ca7a6897"),
                            Title = "Morbi at vestibulum turpis",
                             ImagePath = "news-thumb-6.jpg",
                            Summary = "Suspendisse purus felis, porttitor quis sollicitudin sit amet, elementum et tortor. Praesent lacinia magna in malesuada vestibulum. Pellentesque urna libero.",
                            Body = @"<p class='featured-image'><img class='img-responsive' src='/LMS/App_JS/compounents/collegeGreen/images/news-1.jpg' alt=''></p>    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis. Integer malesuada porta fermentum. Sed luctus nibh sed mi auctor imperdiet. Cras et sapien rhoncus, pulvinar dolor sed, tincidunt massa. Nullam fringilla mauris non risus ultricies viverra. Donec a turpis non lorem pulvinar posuere.</p>    <p>Nulla facilisi. Aenean interdum iaculis odio, et suscipit lorem euismod et. Sed nec orci suscipit, accumsan mauris nec, vestibulum felis. Nam eu felis sem. Fusce ut odio ipsum. Duis orci ipsum, feugiat ac dignissim in, convallis quis tortor. Mauris semper tortor nec justo adipiscing volutpat. Donec suscipit rhoncus est, vitae pretium purus laoreet et. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed iaculis risus felis, sit amet porta urna volutpat vel. Integer vestibulum, neque a condimentum fermentum, est nunc tincidunt nunc, eget sagittis turpis elit nec arcu. Curabitur tempus mauris vitae dignissim vehicula. Fusce vehicula malesuada aliquam.</p>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <ul class='custom-list-style'>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>        <li><i class='fa fa-check'></i>Lorem ipsum dolor sit amet.</li>        <li><i class='fa fa-check'></i>Aliquam tincidunt mauris eu risus.</li>        <li><i class='fa fa-check'></i>Ultricies eget vel aliquam libero.</li>    </ul>    <p>Nullam consequat lectus eget fringilla ultricies. Suspendisse potenti. Morbi in malesuada nibh. Morbi vel tellus eu magna tempor mattis. Praesent ut turpis feugiat, dignissim ipsum et, pharetra orci. Nullam in congue felis. Donec commodo metus metus, at faucibus purus convallis ac. Nullam quis tortor urna. In commodo metus sed tempus venenatis. Integer euismod consectetur lobortis. Mauris blandit in massa in rhoncus. Aliquam sit amet sollicitudin nulla. Ut nec mauris facilisis, pretium enim et, tristique risus. Fusce a ligula in velit congue hendrerit eu eget tortor.</p>    <p class='box'>        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis id nulla at libero ultricies tempus. Duis porta justo quam, ut ultrices felis posuere sit amet. Sed imperdiet bibendum est, sit amet sagittis ante sagittis eu. Ut consequat volutpat sapien sed lobortis. Nullam laoreet vitae justo nec dignissim. <a href='#'>Integer fringilla a purus sit amet laoreet.</a>    </p>",
                            Events =this.Events.Skip(1).Take(3).ToList() 
                         }  
                    };
                }
                return this._news;
            }
            set
            {
                this._news = value;
            }
        }

        public List<Event> Events
        {
            get
            {
                if (this._events == null)
                {

                    this._events = new List<Event>()
                    {
                         new Event()
                         {
                            Id = new Guid("c730fc31-70ef-c8b6-dc1d-08d1cbfbd187"),
                            Title = "Open Day",
                            Location =  "East Campus",
                            DateStart = DateTime.ParseExact("2016-02-18 10:00 UTC +0800", "yyyy'-'MM'-'dd HH:mm 'UTC' K", CultureInfo.InvariantCulture),
                            DateEnd = DateTime.ParseExact("2016-02-18 18:00 UTC +0800", "yyyy'-'MM'-'dd HH:mm 'UTC' K", CultureInfo.InvariantCulture),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                         },
                        new Event()
                        {
                            Id = Guid.NewGuid(),
                            Title = "E-learning at College Green",
                            Location = "Learning Center",
                            DateStart = DateTime.ParseExact("2016-02-18T10:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            DateEnd = DateTime.ParseExact("2016-02-18T16:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                        },
                        new Event()
                        {
                            Id = Guid.NewGuid(),
                            Title = "Career Fair",
                            Location = "Library",
                            DateStart = DateTime.ParseExact("2016-09-28T10:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            DateEnd = DateTime.ParseExact("2016-09-28T16:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                        },
                        new Event() {
                            Id = new Guid("074803e4-0bb9-c7c7-e5c2-08d1cbfbe027"),
                            Title = "Science Seminar",
                            Location = "Library",
                            DateStart = DateTime.ParseExact("2016-05-21T10:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            DateEnd = DateTime.ParseExact("2016-05-21T16:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                        },  
                        new Event(){
                            Id = new Guid("0c071323-0d1e-c193-1ca4-08d1cbfbef33"),
                            Title = "Morbi at vestibulum turpis",
                            Location = "Library",
                            DateStart = DateTime.ParseExact("2016-05-21T10:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            DateEnd = DateTime.ParseExact("2016-05-21T16:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                        }, 
                        new Event(){
                            Id = new Guid("f70b3bcc-3cdf-c624-f3fd-08d1cbfc07e7"),
                            Title = "Morbi at vestibulum turpis",
                            Location = "Library",
                            DateStart = DateTime.ParseExact("2016-08-21T10:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            DateEnd = DateTime.ParseExact("2016-08-18T16:00", "yyyy'-'MM'-'dd'T'HH':'mm", (IFormatProvider)new CultureInfo("en-US"),DateTimeStyles.AssumeLocal),
                            Description= "Donec commodo felis nec eros mollis dignissim. Pellentesque scelerisque nisl eu erat condimentum, at pellentesque odio elementum. Praesent accumsan non quam vel vulputate. Nullam ac hendrerit quam, ut tincidunt felis. Praesent condimentum ut enim ut mattis."
                        },  
                    };
                }
                return this._events;
            }
            set
            {
                this._events = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                if (this._courses == null)
                {
                    this._courses = new List<Course>()
                    {
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Web Design Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Beginner,
                            Mode=CourseMode.Online,
                        },

                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Web Design Advanced",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Advanced,
                            Mode=CourseMode.Local,

                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Web Development Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Online,

                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Digital Marketing Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Online,

                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Digital Marketing Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Local,
                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Digital Marketing Advanced",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Local,
                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Accounting Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Advanced,
                            Mode=CourseMode.Local,
                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Accounting Foundation",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Local,
                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Applied Mathematics",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Intermediate,
                            Mode=CourseMode.Local,
                        },
                        new Course()
                        {
                            Id=Guid.NewGuid(),
                            Name = "Applied Physics",
                            Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",
                            Level=CourseLevel.Advanced,
                            Mode=CourseMode.Local,
                        },

                    };
                }

                return this._courses;
            }
            set { this._courses = value; }
        }
    }
}
