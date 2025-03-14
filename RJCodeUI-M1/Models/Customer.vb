Imports System.ComponentModel

Namespace Models
    Public Class Customer

        ''' <summary>
        ''' This class was created for testing purposes only,
        ''' the data may be inaccurate and meaningless.
        ''' </summary>
        '''  

        Private _names As String
        Private _phoneNumber As String
        Private _email As String
        Private _streetAddres As String

        <DisplayName("Full name")>
        Public Property Names As String
            Get
                Return _names
            End Get
            Set(value As String)
                _names = value
            End Set
        End Property

        <DisplayName("Phone number")>
        Public Property PhoneNumber As String
            Get
                Return _phoneNumber
            End Get
            Set(value As String)
                _phoneNumber = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set
        End Property

        <DisplayName("Street addres")>
        Public Property StreetAddres As String
            Get
                Return _streetAddres
            End Get
            Set(value As String)
                _streetAddres = value
            End Set
        End Property

        Public Function GetCustomerList() As List(Of Customer)
            Dim list = New List(Of Customer)()
            list.Add(New Customer With {
                .Names = "Amethyst Johns",
                .PhoneNumber = "16660227 0248",
                .Email = "pede.blandit.congue@egestasAliquamnec.org",
                .StreetAddres = "293-7752 Aenean Street"
            })
            list.Add(New Customer With {
                .Names = "Leandra Copeland",
                .PhoneNumber = "16571109 2592",
                .Email = "lorem.Donec.elementum@etmagnis.ca",
                .StreetAddres = "Ap #236-6886 Mauris, Avenue"
            })
            list.Add(New Customer With {
                .Names = "Susan Keith",
                .PhoneNumber = "16610225 3371",
                .Email = "Aenean.gravida.nunc@nonlaciniaat.ca",
                .StreetAddres = "4388 Eu Ave"
            })
            list.Add(New Customer With {
                .Names = "Odysseus Matthews",
                .PhoneNumber = "16700101 4674",
                .Email = "orci.quis.lectus@risusNullaeget.edu",
                .StreetAddres = "7347 Convallis Rd."
            })
            list.Add(New Customer With {
                .Names = "Bianca Goodman",
                .PhoneNumber = "16490620 8238",
                .Email = "mattis@Integertinciduntaliquam.com",
                .StreetAddres = "P.O. Box 800, 1463 Nec Rd."
            })
            list.Add(New Customer With {
                .Names = "Carlos Mccarthy",
                .PhoneNumber = "16500213 8245",
                .Email = "urna.Vivamus.molestie@lectus.org",
                .StreetAddres = "8118 Vel Rd."
            })
            list.Add(New Customer With {
                .Names = "Hyatt Flores",
                .PhoneNumber = "16841201 0103",
                .Email = "Pellentesque.ultricies@hymenaeos.edu",
                .StreetAddres = "6687 Quis, Rd."
            })
            list.Add(New Customer With {
                .Names = "Abbot Odom",
                .PhoneNumber = "16300322 7109",
                .Email = "massa.Integer@nibhdolor.co.uk",
                .StreetAddres = "P.O. Box 356, 3878 Scelerisque, Street"
            })
            list.Add(New Customer With {
                .Names = "Maryam Fuentes",
                .PhoneNumber = "16251010 5949",
                .Email = "Proin@semperrutrumFusce.net",
                .StreetAddres = "359 Sociis Avenue"
            })
            list.Add(New Customer With {
                .Names = "Lila Valenzuela",
                .PhoneNumber = "16660126 6874",
                .Email = "mus.Aenean.eget@faucibusMorbi.edu",
                .StreetAddres = "267-7306 Penatibus Avenue"
            })
            list.Add(New Customer With {
                .Names = "Abdul Todd",
                .PhoneNumber = "16630926 2761",
                .Email = "Aenean.eget@Classaptent.co.uk",
                .StreetAddres = "296-1682 Ultrices Rd."
            })
            list.Add(New Customer With {
                .Names = "Cyrus Tillman",
                .PhoneNumber = "16530807 8525",
                .Email = "Donec@erosturpisnon.com",
                .StreetAddres = "135-8573 Turpis Rd."
            })
            list.Add(New Customer With {
                .Names = "Brock Peters",
                .PhoneNumber = "16951104 1346",
                .Email = "cursus@nonantebibendum.net",
                .StreetAddres = "8808 Fusce Ave"
            })
            list.Add(New Customer With {
                .Names = "Alisa Strong",
                .PhoneNumber = "16250823 0485",
                .Email = "vitae.aliquam@eratvolutpatNulla.ca",
                .StreetAddres = "719-7203 Aliquam Ave"
            })
            list.Add(New Customer With {
                .Names = "Fiona Snyder",
                .PhoneNumber = "16090705 8812",
                .Email = "Nullam@semmolestie.org",
                .StreetAddres = "3706 Dapibus Street"
            })
            list.Add(New Customer With {
                .Names = "Miranda Kennedy",
                .PhoneNumber = "16720212 3829",
                .Email = "viverra.Donec@necleoMorbi.com",
                .StreetAddres = "Ap #515-5687 Non, St."
            })
            list.Add(New Customer With {
                .Names = "Chester Buck",
                .PhoneNumber = "16600401 2503",
                .Email = "aliquet.molestie@Cumsociisnatoque.ca",
                .StreetAddres = "Ap #769-9387 Mauris Street"
            })
            list.Add(New Customer With {
                .Names = "Mark Page",
                .PhoneNumber = "16411003 1764",
                .Email = "egestas.a@ipsumdolor.edu",
                .StreetAddres = "Ap #620-8858 Ac, Road"
            })
            list.Add(New Customer With {
                .Names = "Axel Allen",
                .PhoneNumber = "16631028 5264",
                .Email = "fermentum.arcu.Vestibulum@congueturpis.ca",
                .StreetAddres = "Ap #319-1550 Aliquet Ave"
            })
            list.Add(New Customer With {
                .Names = "Molly Hays",
                .PhoneNumber = "16690905 9492",
                .Email = "tristique.ac@risus.ca",
                .StreetAddres = "6797 Ac Ave"
            })
            list.Add(New Customer With {
                .Names = "Jael Booth",
                .PhoneNumber = "16710508 8574",
                .Email = "dignissim.tempor@tinciduntvehicula.org",
                .StreetAddres = "Ap #422-3874 Sit St."
            })
            list.Add(New Customer With {
                .Names = "Keefe Sutton",
                .PhoneNumber = "16210421 4123",
                .Email = "gravida@pretiumaliquet.edu",
                .StreetAddres = "557-9183 Tellus Avenue"
            })
            list.Add(New Customer With {
                .Names = "Alexandra Sampson",
                .PhoneNumber = "16930808 0093",
                .Email = "ligula.Nullam.feugiat@consectetuermaurisid.org",
                .StreetAddres = "658-9403 Amet Av."
            })
            list.Add(New Customer With {
                .Names = "Rahim Marquez",
                .PhoneNumber = "16040130 1783",
                .Email = "amet.faucibus@dictum.net",
                .StreetAddres = "328-8293 Cum Road"
            })
            list.Add(New Customer With {
                .Names = "Gretchen Hebert",
                .PhoneNumber = "16200612 8108",
                .Email = "dictum.augue.malesuada@turpisvitae.com",
                .StreetAddres = "P.O. Box 331, 7823 Magnis St."
            })
            list.Add(New Customer With {
                .Names = "Arden Conley",
                .PhoneNumber = "16810713 7849",
                .Email = "ipsum@id.edu",
                .StreetAddres = "353-3267 Blandit St."
            })
            list.Add(New Customer With {
                .Names = "Calista Christensen",
                .PhoneNumber = "16740314 7221",
                .Email = "enim.non.nisi@apurusDuis.edu",
                .StreetAddres = "278-8063 Viverra. Street"
            })
            list.Add(New Customer With {
                .Names = "Demetrius Murray",
                .PhoneNumber = "16510406 8233",
                .Email = "dolor.sit.amet@indolorFusce.co.uk",
                .StreetAddres = "912-3253 Donec St."
            })
            list.Add(New Customer With {
                .Names = "Mary Hebert",
                .PhoneNumber = "16230216 3031",
                .Email = "Aliquam.nisl@justofaucibus.co.uk",
                .StreetAddres = "448-2361 Bibendum. Road"
            })
            list.Add(New Customer With {
                .Names = "Peter Bender",
                .PhoneNumber = "16440613 3795",
                .Email = "sed.sem.egestas@velit.edu",
                .StreetAddres = "P.O. Box 271, 7818 Odio. St."
            })
            list.Add(New Customer With {
                .Names = "Mason Patterson",
                .PhoneNumber = "16241107 2347",
                .Email = "Suspendisse@temporest.edu",
                .StreetAddres = "P.O. Box 985, 1804 Arcu Rd."
            })
            list.Add(New Customer With {
                .Names = "Hanae Bean",
                .PhoneNumber = "16861125 9634",
                .Email = "Integer.vulputate@tinciduntvehicula.net",
                .StreetAddres = "Ap #677-165 Libero. Avenue"
            })
            list.Add(New Customer With {
                .Names = "Noble Morrow",
                .PhoneNumber = "16660405 3774",
                .Email = "augue.id.ante@Suspendisseac.com",
                .StreetAddres = "3916 Ac, Street"
            })
            list.Add(New Customer With {
                .Names = "Cameron Boyd",
                .PhoneNumber = "16190407 9090",
                .Email = "nec.orci@euismodurna.net",
                .StreetAddres = "P.O. Box 733, 3921 Elementum Avenue"
            })
            list.Add(New Customer With {
                .Names = "Yoshi Pennington",
                .PhoneNumber = "16940225 0626",
                .Email = "mauris.aliquam.eu@necluctus.com",
                .StreetAddres = "Ap #150-6179 Curabitur Ave"
            })
            list.Add(New Customer With {
                .Names = "Peter Morse",
                .PhoneNumber = "16781213 0925",
                .Email = "consequat@Aenean.ca",
                .StreetAddres = "1452 Nibh. Ave"
            })
            list.Add(New Customer With {
                .Names = "Chiquita Jenkins",
                .PhoneNumber = "16320311 4842",
                .Email = "ut@estNuncullamcorper.ca",
                .StreetAddres = "4124 Risus. St."
            })
            list.Add(New Customer With {
                .Names = "Hamilton Macias",
                .PhoneNumber = "16830211 8859",
                .Email = "massa.Suspendisse@Donecfringilla.ca",
                .StreetAddres = "P.O. Box 830, 2739 Non St."
            })
            list.Add(New Customer With {
                .Names = "Shana Harvey",
                .PhoneNumber = "16850718 4565",
                .Email = "arcu.imperdiet.ullamcorper@convallis.net",
                .StreetAddres = "P.O. Box 228, 8638 Nulla Road"
            })
            list.Add(New Customer With {
                .Names = "Olivia Henson",
                .PhoneNumber = "16481017 0508",
                .Email = "parturient.montes@nislarcuiaculis.ca",
                .StreetAddres = "548-2704 Lobortis. Av."
            })
            list.Add(New Customer With {
                .Names = "Alvin Petersen",
                .PhoneNumber = "16790802 6789",
                .Email = "arcu.Sed.et@velesttempor.com",
                .StreetAddres = "P.O. Box 324, 5273 Parturient Rd."
            })
            list.Add(New Customer With {
                .Names = "Damon Kramer",
                .PhoneNumber = "16950318 5432",
                .Email = "nec.malesuada.ut@nonummyutmolestie.org",
                .StreetAddres = "Ap #605-2375 Lorem, Ave"
            })
            list.Add(New Customer With {
                .Names = "Alvin Hebert",
                .PhoneNumber = "16630230 1772",
                .Email = "odio@nisi.edu",
                .StreetAddres = "Ap #659-9644 Id, Rd."
            })
            list.Add(New Customer With {
                .Names = "Garrett Adkins",
                .PhoneNumber = "16740126 0083",
                .Email = "ligula.elit@libero.net",
                .StreetAddres = "P.O. Box 333, 2134 Pharetra. Rd."
            })
            list.Add(New Customer With {
                .Names = "Yolanda Mitchell",
                .PhoneNumber = "16770206 7369",
                .Email = "nunc.nulla.vulputate@augue.org",
                .StreetAddres = "Ap #930-5187 Vel St."
            })
            list.Add(New Customer With {
                .Names = "Karly Herring",
                .PhoneNumber = "16600307 7747",
                .Email = "Nullam.vitae.diam@luctusvulputatenisi.org",
                .StreetAddres = "P.O. Box 934, 5818 A Road"
            })
            list.Add(New Customer With {
                .Names = "Ifeoma Mcconnell",
                .PhoneNumber = "16631106 9949",
                .Email = "semper.pretium.neque@massa.net",
                .StreetAddres = "857-6085 Bibendum Ave"
            })
            list.Add(New Customer With {
                .Names = "Isabella Donovan",
                .PhoneNumber = "16160527 9890",
                .Email = "montes@euismodenimEtiam.com",
                .StreetAddres = "2692 Et St."
            })
            list.Add(New Customer With {
                .Names = "Thane Hayden",
                .PhoneNumber = "16740927 7618",
                .Email = "vel.faucibus.id@felis.net",
                .StreetAddres = "P.O. Box 273, 5370 Per St."
            })
            list.Add(New Customer With {
                .Names = "Gabriel Fletcher",
                .PhoneNumber = "16821015 4368",
                .Email = "vehicula.aliquet.libero@enim.com",
                .StreetAddres = "P.O. Box 869, 8348 Rutrum. Avenue"
            })
            list.Add(New Customer With {
                .Names = "Cole Leblanc",
                .PhoneNumber = "16730801 6471",
                .Email = "dignissim.lacus@pede.edu",
                .StreetAddres = "Ap #395-2815 Dolor Av."
            })
            list.Add(New Customer With {
                .Names = "Connor Beck",
                .PhoneNumber = "16590419 4668",
                .Email = "dui.nec.urna@fermentumvelmauris.net",
                .StreetAddres = "Ap #470-6867 Ac St."
            })
            list.Add(New Customer With {
                .Names = "Ulysses Campbell",
                .PhoneNumber = "16340606 5528",
                .Email = "Donec@eratSednunc.ca",
                .StreetAddres = "P.O. Box 493, 8285 Vel Street"
            })
            list.Add(New Customer With {
                .Names = "Jonas Dawson",
                .PhoneNumber = "16280924 4573",
                .Email = "Aliquam@musProinvel.co.uk",
                .StreetAddres = "Ap #286-2435 Donec Street"
            })
            list.Add(New Customer With {
                .Names = "Dara Knight",
                .PhoneNumber = "16930114 1553",
                .Email = "felis@felisNullatempor.net",
                .StreetAddres = "Ap #957-1301 Elit, Ave"
            })
            list.Add(New Customer With {
                .Names = "Ila Butler",
                .PhoneNumber = "16580728 4681",
                .Email = "vitae.semper.egestas@eliteratvitae.edu",
                .StreetAddres = "2553 Ornare, Ave"
            })
            list.Add(New Customer With {
                .Names = "Melinda Irwin",
                .PhoneNumber = "16430419 7876",
                .Email = "sem.ut@magna.com",
                .StreetAddres = "P.O. Box 474, 9027 Vel Road"
            })
            list.Add(New Customer With {
                .Names = "Echo Briggs",
                .PhoneNumber = "16230215 1796",
                .Email = "leo.in@aliquameros.ca",
                .StreetAddres = "6726 Cursus Avenue"
            })
            list.Add(New Customer With {
                .Names = "William Alford",
                .PhoneNumber = "16590115 6173",
                .Email = "vitae.sodales.at@egestas.edu",
                .StreetAddres = "P.O. Box 378, 8400 Amet Av."
            })
            list.Add(New Customer With {
                .Names = "Dora Grant",
                .PhoneNumber = "16801206 3239",
                .Email = "adipiscing.elit@cursusnonegestas.org",
                .StreetAddres = "6786 In Av."
            })
            list.Add(New Customer With {
                .Names = "Phillip Walton",
                .PhoneNumber = "16630510 4116",
                .Email = "orci@variusultrices.ca",
                .StreetAddres = "P.O. Box 426, 259 Orci St."
            })
            list.Add(New Customer With {
                .Names = "Ursula Massey",
                .PhoneNumber = "16590901 4945",
                .Email = "tempor@molestiein.edu",
                .StreetAddres = "P.O. Box 332, 6288 Volutpat. Rd."
            })
            list.Add(New Customer With {
                .Names = "Griffith Everett",
                .PhoneNumber = "16810526 8976",
                .Email = "non.dui@acfermentumvel.edu",
                .StreetAddres = "P.O. Box 224, 236 Ante Road"
            })
            list.Add(New Customer With {
                .Names = "Quentin Cunningham",
                .PhoneNumber = "16670907 0673",
                .Email = "In.scelerisque.scelerisque@sedfacilisis.edu",
                .StreetAddres = "Ap #811-6159 Turpis Av."
            })
            list.Add(New Customer With {
                .Names = "Grady Middleton",
                .PhoneNumber = "16231123 6786",
                .Email = "semper.cursus@Sed.net",
                .StreetAddres = "P.O. Box 303, 4041 Blandit Road"
            })
            list.Add(New Customer With {
                .Names = "Alika William",
                .PhoneNumber = "16140105 1626",
                .Email = "pellentesque.tellus@Namac.co.uk",
                .StreetAddres = "6477 Pulvinar Street"
            })
            list.Add(New Customer With {
                .Names = "Quintessa Valenzuela",
                .PhoneNumber = "16320709 1848",
                .Email = "non@In.co.uk",
                .StreetAddres = "Ap #664-7938 Duis St."
            })
            list.Add(New Customer With {
                .Names = "Adele Hull",
                .PhoneNumber = "16350123 4557",
                .Email = "risus@vulputateeuodio.ca",
                .StreetAddres = "P.O. Box 530, 9119 Lectus Ave"
            })
            list.Add(New Customer With {
                .Names = "Kelly Whitfield",
                .PhoneNumber = "16200312 4803",
                .Email = "odio@IntegermollisInteger.ca",
                .StreetAddres = "267-8953 Pede. Av."
            })
            list.Add(New Customer With {
                .Names = "Amanda Sellers",
                .PhoneNumber = "16860315 9891",
                .Email = "aliquet@auctorvelitAliquam.net",
                .StreetAddres = "P.O. Box 450, 5259 Dui. St."
            })
            list.Add(New Customer With {
                .Names = "Evan Wolf",
                .PhoneNumber = "16510705 9353",
                .Email = "a.sollicitudin.orci@eu.net",
                .StreetAddres = "P.O. Box 297, 5299 Nullam Rd."
            })
            list.Add(New Customer With {
                .Names = "Brenda Mcpherson",
                .PhoneNumber = "16631207 9558",
                .Email = "Donec.at@molestietellusAenean.co.uk",
                .StreetAddres = "593-9779 Adipiscing St."
            })
            list.Add(New Customer With {
                .Names = "Hedwig Guerra",
                .PhoneNumber = "16570807 9099",
                .Email = "magna.Lorem@Inornare.net",
                .StreetAddres = "4791 Felis Ave"
            })
            list.Add(New Customer With {
                .Names = "Constance Key",
                .PhoneNumber = "16970121 1576",
                .Email = "vel.arcu@ametrisusDonec.ca",
                .StreetAddres = "205-8051 Dictum Rd."
            })
            list.Add(New Customer With {
                .Names = "Eagan Dennis",
                .PhoneNumber = "16990719 5987",
                .Email = "justo@Sed.net",
                .StreetAddres = "P.O. Box 449, 5856 Et St."
            })
            list.Add(New Customer With {
                .Names = "Evan Parks",
                .PhoneNumber = "16610515 3842",
                .Email = "Maecenas.libero.est@nequeNullam.com",
                .StreetAddres = "Ap #420-4250 Odio. Rd."
            })
            list.Add(New Customer With {
                .Names = "Kareem Chavez",
                .PhoneNumber = "16760114 9771",
                .Email = "sagittis@amet.com",
                .StreetAddres = "P.O. Box 270, 6484 Pede St."
            })
            list.Add(New Customer With {
                .Names = "Indigo Lewis",
                .PhoneNumber = "16690215 6931",
                .Email = "adipiscing@nonegestasa.net",
                .StreetAddres = "2295 Lacus. Ave"
            })
            list.Add(New Customer With {
                .Names = "Bryar Simon",
                .PhoneNumber = "16660610 0763",
                .Email = "eu.nulla.at@scelerisque.com",
                .StreetAddres = "Ap #166-9414 Ante. St."
            })
            list.Add(New Customer With {
                .Names = "Akeem Tanner",
                .PhoneNumber = "16900425 8092",
                .Email = "montes@feugiatmetussit.org",
                .StreetAddres = "5406 Magna. St."
            })
            list.Add(New Customer With {
                .Names = "Quintessa Leonard",
                .PhoneNumber = "16951203 5941",
                .Email = "penatibus@euismod.edu",
                .StreetAddres = "P.O. Box 969, 9646 Aliquam Rd."
            })
            list.Add(New Customer With {
                .Names = "Porter Tillman",
                .PhoneNumber = "16350330 6379",
                .Email = "Vestibulum.ut@sit.org",
                .StreetAddres = "Ap #445-4188 Eget, Road"
            })
            list.Add(New Customer With {
                .Names = "Whilemina Campos",
                .PhoneNumber = "16970323 9468",
                .Email = "Praesent.interdum.ligula@Fusce.ca",
                .StreetAddres = "7309 Elit Ave"
            })
            list.Add(New Customer With {
                .Names = "Igor Madden",
                .PhoneNumber = "16920809 8765",
                .Email = "Sed.nulla@atiaculisquis.org",
                .StreetAddres = "Ap #156-7070 Augue Rd."
            })
            list.Add(New Customer With {
                .Names = "Renee Martin",
                .PhoneNumber = "16570921 1949",
                .Email = "vulputate@enimEtiamimperdiet.edu",
                .StreetAddres = "3396 Eu Av."
            })
            list.Add(New Customer With {
                .Names = "Sacha Key",
                .PhoneNumber = "16530604 1475",
                .Email = "nunc.risus@Nuncquisarcu.org",
                .StreetAddres = "P.O. Box 576, 4517 Velit. Avenue"
            })
            list.Add(New Customer With {
                .Names = "Alice Howard",
                .PhoneNumber = "16660604 9218",
                .Email = "nisi@augueidante.com",
                .StreetAddres = "P.O. Box 415, 1331 Nunc Rd."
            })
            list.Add(New Customer With {
                .Names = "Julian Cox",
                .PhoneNumber = "16881201 5603",
                .Email = "facilisis.magna.tellus@nec.ca",
                .StreetAddres = "8632 Nunc St."
            })
            list.Add(New Customer With {
                .Names = "Nero Hodges",
                .PhoneNumber = "16840324 4851",
                .Email = "interdum.ligula@indolorFusce.ca",
                .StreetAddres = "Ap #210-6708 Pulvinar St."
            })
            list.Add(New Customer With {
                .Names = "Jacqueline Mcmahon",
                .PhoneNumber = "16540220 4472",
                .Email = "urna@ipsum.co.uk",
                .StreetAddres = "752-6873 A St."
            })
            list.Add(New Customer With {
                .Names = "Calista Cooper",
                .PhoneNumber = "16850412 3301",
                .Email = "purus.gravida.sagittis@eutemporerat.org",
                .StreetAddres = "P.O. Box 813, 3354 Duis Rd."
            })
            list.Add(New Customer With {
                .Names = "Joy Olson",
                .PhoneNumber = "16440323 8936",
                .Email = "elit.pellentesque.a@pede.net",
                .StreetAddres = "561-5024 Sit Rd."
            })
            list.Add(New Customer With {
                .Names = "Leilani Harris",
                .PhoneNumber = "16410126 2584",
                .Email = "nulla.Integer.vulputate@molestie.co.uk",
                .StreetAddres = "977-8154 Dictum Street"
            })
            list.Add(New Customer With {
                .Names = "Kareem Holcomb",
                .PhoneNumber = "16140522 9889",
                .Email = "Nunc.quis.arcu@Nunc.net",
                .StreetAddres = "P.O. Box 423, 4196 Ipsum St."
            })
            list.Add(New Customer With {
                .Names = "Quinn Crane",
                .PhoneNumber = "16640213 6409",
                .Email = "ante@leoin.com",
                .StreetAddres = "P.O. Box 597, 4340 At Road"
            })
            list.Add(New Customer With {
                .Names = "Paloma Lindsay",
                .PhoneNumber = "16820202 9826",
                .Email = "sem@maurissapien.ca",
                .StreetAddres = "P.O. Box 314, 6814 Fames Avenue"
            })
            list.Add(New Customer With {
                .Names = "Thaddeus Hines",
                .PhoneNumber = "16660628 1357",
                .Email = "semper.dui@sagittisNullamvitae.net",
                .StreetAddres = "917-7770 Feugiat St."
            })
            list.Add(New Customer With {
                .Names = "Reese Hopper",
                .PhoneNumber = "16720723 2989",
                .Email = "Aenean.sed@eu.com",
                .StreetAddres = "1367 Eleifend. Street"
            })
            list.Add(New Customer With {
                .Names = "Neil Kinney",
                .PhoneNumber = "16830220 6936",
                .Email = "neque.Sed@at.net",
                .StreetAddres = "182-4395 Mauris St."
            })
            list.Add(New Customer With {
                .Names = "Bruno Giles",
                .PhoneNumber = "16480812 8914",
                .Email = "iaculis.quis.pede@montesnascetur.com",
                .StreetAddres = "Ap #896-744 Eleifend St."
            })
            Return list
        End Function
    End Class

End Namespace
