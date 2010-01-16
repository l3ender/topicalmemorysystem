using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{
	public class TMSVerses
	{
		public static VersePack A_PACK()
		{
			VersePack vp = new VersePack("");
			vp.Name = "A - Live The New Life";
			vp.AddVerse(new Verse("2 Corinthians", 5, "17", "A-1", "Live The New Life", "Christ the Center",
				"Therefore, if anyone is in Christ, he is a new creation; the old has gone, the new has come!",
				"Therefore, if anyone is in Christ, he is a new creation.  The old has passed away; behold, the new has come.",
				"2 Korintiers", "Daarom ook is iemand die een met Christus is, een nieuwe schepping. Het oude is voorbij, het nieuwe is gekomen.",
				true));
			vp.AddVerse(new Verse("Galatians", 2, "20", "A-2", "Live The New Life", "Christ the Center",
				"I have been crucified with Christ and I no longer live, but Christ lives in me. The life I live in the body, I live by faith in the Son of God, who loved me and gave himself for me.",
				"I have been crucified with Christ. It is no longer I who live, but Christ who lives in me. And the life I now live in the flesh I live by faith in the Son of God, who loved me and gave himself for me.",
				"Galaten", "Ikzelf leef niet meer, maar Christus leeft in mij. Mijn leven hier op aarde leef ik in het geloof in de Zoon van God, die mij heeft liefgehad en zich voor mij heeft prijsgegeven.",
				true));
			vp.AddVerse(new Verse("Romans", 12, "1", "A-3", "Live The New Life", "Obedience to Christ",
				"Therefore, I urge you, brothers, in view of God's mercy, to offer your bodies as living sacrifices, holy and pleasing to God--this is your spiritual act of worship.",
				"I appeal to you therefore, brothers, by the mercies of God, to present your bodies as a living sacrifice, holy and acceptable to God, which is your spiritual worship.",
				"Romeinen", "Broeders en zusters, met een beroep op Gods barmhartigheid vraag ik u om uzelf als een levend, heilig en God welgevallig offer in zijn dienst te stellen, want dat is de ware eredienst voor u.",
				true));
			vp.AddVerse(new Verse("John", 14, "21", "A-4", "Live The New Life", "Obedience to Christ",
				"\"Whoever has my commands and obeys them, he is the one who loves me. He who loves me will be loved by my Father, and I too will love him and show myself to him.\"",
				"\"Whoever has my commandments and keeps them, he it is who loves me. And he who loves me will be loved by my Father, and I will love him and manifest myself to him.\"",
				"Johannes", "\"Wie mijn geboden kent en zich eraan houdt, heeft mij lief. Wie mij liefheeft zal de liefde van mijn Vader en mij ontvangen, en ik zal mij aan hem bekendmaken.\"",
				true));
			vp.AddVerse(new Verse("2 Timothy", 3, "16", "A-5", "Live The New Life", "The Word",
				"All Scripture is God-breathed and is useful for teaching, rebuking, correcting and training in righteousness",
				"All Scripture is breathed out by God and profitable for teaching, for reproof, for correction, and for training in righteousness",
				"2 Timoteus", "Elke schrifttekst is door God geinspireerd en kan gebruikt worden om onderricht te geven, om dwalingen en fouten te weerleggen, en om op te voeden tot een deugdzaam leven",
				true));
			vp.AddVerse(new Verse("Joshua", 1, "8", "A-6", "Live The New Life", "The Word",
				"Do not let this Book of the Law depart from your mouth; meditate on it day and night, so that you may be careful to do everything written in it. Then you will be prosperous and successful.",
				"\"This Book of the Law shall not depart from your mouth, but you shall meditate on it day and night, so that you may be careful to do according to all that is written in it. For then you will make your way prosperous, and then you will have good success.\"",
				"Jozua", "Leg dat wetboek geen moment terzijde en verdiep je er dag en nacht in, opdat je je aan alles houdt wat erin geschreven staat. Dan zal alles wat je onderneemt voorspoedig verlopen.",
				true));
			vp.AddVerse(new Verse("John", 15, "7", "A-7", "Live The New Life", "Prayer",
				"If you remain in me and my words remain in you, ask whatever you wish, and it will be given you.",
				"\"If you abide in me, and my words abide in you, ask whatever you wish, and it will be done for you.\"",
				"Johannes", "Als jullie in mij blijven en mijn woorden in jullie, kun je vragen wat je wilt en het zal gebeuren.",
				true));
			vp.AddVerse(new Verse("Philippians", 4, "6,7", "A-8", "Live The New Life", "Prayer",
				"Do not be anxious about anything, but in everything, by prayer and petition, with thanksgiving, present your requests to God.  And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus.",
				"Do not be anxious about anything, but in everything by prayer and supplication with thanksgiving let your requests be made known to God.  And the peace of God, which surpasses all understanding, will guard your hearts and your minds in Christ Jesus.",
				"Filippenzen", "Wees over niets bezorgd, maar vraag God wat u nodig hebt en dank hem in al uw gebeden.  Dan zal de vrede van God, die alle verstand te boven gaat, uw hart en gedachten in Christus Jezus bewaren.",
				true));
			vp.AddVerse(new Verse("Matthew", 18, "20", "A-9", "Live The New Life", "Fellowship",
				"\"For where two or three come together in my name, there am I with them.\"",
				"\"For where two or three are gathered in my name, there am I among them.\"",
				"Matteus", "\"Want waar twee of drie mensen in mijn naam samen zijn, ben ik in hun midden.\"",
				true));
			vp.AddVerse(new Verse("Hebrews", 10, "24,25", "A-10", "Live The New Life", "Fellowship",
				"And let us consider how we may spur one another on toward love and good deeds.  Let us not give up meeting together, as some are in the habit of doing, but let us encourage one another--and all the more as you see the Day approaching.",
				"And let us consider how to stir up one another to love and good works, not neglecting to meet together, as is the habit of some, but encouraging one another, and all the more as you see the Day drawing near.",
				"Hebreeen", "Laten we opmerkzaam blijven en elkaar ertoe aansporen lief te hebben en goed te doen, en in plaats van weg te blijven van onze samenkomsten, zoals sommigen doen, elkaar juist bemoedigen, en dat des te meer naarmate u de dag van zijn komst ziet naderen.",
				true));
			vp.AddVerse(new Verse("Matthew", 4, "19", "A-11", "Live The New Life", "Witnessing",
				"\"Come, follow me,\" Jesus said, \"and I will make you fishers of men.\"",
				"And he said to them, \"Follow me, and I will make you fishers of men.\"",
				"Matteus", "Hij zei tegen hen: \"Kom, volg mij, ik zal van jullie vissers van mensen maken.\"",
				true));
			vp.AddVerse(new Verse("Romans", 1, "16", "A-12", "Live The New Life", "Witnessing",
				"I am not ashamed of the gospel, because it is the power of God for the salvation of everyone who believes: first for the Jew, then for the Gentile.",
				"For I am not ashamed of the gospel, for it is the power of God for salvation to everyone who believes, to the Jew first and also to the Greek.",
				"Romeinen", "Voor dit evangelie schaam ik mij niet, want het is Gods reddende kracht voor allen die geloven, voor Joden in de eerste plaats, maar ook voor andere volken.",
				true));
			return vp;
		}

		public static VersePack B_PACK()
		{
			VersePack vp = new VersePack("");
			vp.Name = "B - Proclaim Christ";
			vp.AddVerse(new Verse("Romans", 3, "23", "B-1", "Proclaim Christ", "All Have Sinned",
				"For all have sinned and fall short of the glory of God",
				"For all have sinned and fall short of the glory of God",
				"Romeinen", "Iedereen heeft gezondigd en ontbeert de nabijheid van God",
				true));
			vp.AddVerse(new Verse("Isaiah", 53, "6", "B-2", "Proclaim Christ", "All Have Sinned",
				"We all, like sheep, have gone astray, each of us has turned to his own way; and the Lord has laid on him the iniquity of us all.",
				"All we like sheep have gone astray; we have turned every one to his own way; and the Lord has laid on him the iniquity of us all.",
				"Jesaja", "Wij dwaalden rond als schapen, ieder zocht zijn eigen weg; maar de wandaden van ons allen liet de HEER op hem neerkomen.",
				true));
			vp.AddVerse(new Verse("Romans", 6, "23", "B-3", "Proclaim Christ", "Sin's Penalty",
				"For the wages of sin is death, but the gift of God is eternal life in Christ Jesus our Lord.",
				"For the wages of sin is death, but the free gift of God is eternal life in Christ Jesus our Lord.",
				"Romeinen", "Het loon van de zonde is de dood, maar het geschenk van God is het eeuwige leven in Christus Jezus, onze Heer.",
				true));
			vp.AddVerse(new Verse("Hebrews", 9, "27", "B-4", "Proclaim Christ", "Sin's Penalty",
				"Just as man is destined to die once, and after that to face judgment",
				"And just as it is appointed for man to die once, and after that comes judgment",
				"Hebreeen", "Eens moeten mensen sterven en daarna volgt het oordeel.",
				true));
			vp.AddVerse(new Verse("Romans", 5, "8", "B-5", "Proclaim Christ", "Christ Paid the Penalty",
				"But God demonstrates his own love for us in this: While we were still sinners, Christ died for us.",
				"But God shows his love for us in that while we were still sinners, Christ died for us.",
				"Romeinen", "Maar God bewees ons zijn liefde doordat Christus voor ons gestorven is toen wij nog zondaars waren.",
				true));
			vp.AddVerse(new Verse("1 Peter", 3, "18", "B-6", "Proclaim Christ", "Christ Paid the Penalty",
				"For Christ died for sins once for all, the righteous for the unrighteous, to bring you to God. He was put to death in the body but made alive by the Spirit",
				"For Christ also suffered once for sins, the righteous for the unrighteous, that he might bring us to God, being put to death in the flesh but made alive in the spirit",
				"1 Petrus", "Ook Christus immers heeft, terwijl hij zelf rechtvaardig was, geleden voor de zonden van onrechtvaardigen, voor eens en altijd, om u zo bij God te brengen. Naar het lichaam werd hij gedood maar naar de geest tot leven gewekt.",
				true));
			vp.AddVerse(new Verse("Ephesians", 2, "8,9", "B-7", "Proclaim Christ", "Salvation is not by Works",
				"For it is by grace you have been saved, through faith--and this not from yourselves, it is the gift of God--not by works, so that no one can boast.",
				"For by grace you have been saved through faith. And this is not your own doing; it is the gift of God, not a result of works, so that no one may boast.",
				"Efeziers", "Door zijn genade bent u nu immers gered, dankzij uw geloof. Maar dat dankt u niet aan uzelf; het is een geschenk van God en geen gevolg van uw daden, dus niemand kan zich erop laten voorstaan.",
				true));
			vp.AddVerse(new Verse("Titus", 3, "5", "B-8", "Proclaim Christ", "Salvation is not by Works",
				"He saved us, not because of righteous things we had done, but because of his mercy. He saved us through the washing of rebirth and renewal by the Holy Spirit",
				"He saved us, not because of works done by us in righteousness, but according to his own mercy, by the washing of regeneration and renewal of the Holy Spirit",
				"Titus", "En heeft hij ons gered, niet vanwege onze rechtvaardige daden, maar uit barmhartigheid. Hij heeft ons gered door het bad van de wedergeboorte en de vernieuwende kracht van de heilige Geest",
				true));
			vp.AddVerse(new Verse("John", 1, "12", "B-9", "Proclaim Christ", "Must Receive Christ",
				"Yet to all who received him, to those who believed in his name, he gave the right to become children of God",
				"But to all who did receive him, who believed in his name, he gave the right to become children of God",
				"Johannes", "Wie hem wel ontvingen en in zijn naam geloven, heeft hij het voorrecht gegeven om kinderen van God te worden.",
				true));
			vp.AddVerse(new Verse("Revelation", 3, "20", "B-10", "Proclaim Christ", "Must Receive Christ",
				"Here I am! I stand at the door and knock. If anyone hears my voice and opens the door, I will come in and eat with him, and he with me.",
				"\"Behold, I stand at the door and knock. If anyone hears my voice and opens the door, I will come in to him and eat with him, and he with me.\"",
				"Openbaring", "Ik sta voor de deur en klop aan. Als iemand mijn stem hoort en de deur opent, zal ik binnenkomen, en we zullen samen eten, ik met hem en hij met mij.",
				true));
			vp.AddVerse(new Verse("1 John", 5, "13", "B-11", "Proclaim Christ", "Assurance of Salvation",
				"I write these things to you who believe in the name of the Son of God so that you may know that you have eternal life.",
				"I write these things to you who believe in the name of the Son of God that you may know that you have eternal life.",
				"1 Johannes", "Dit alles schrijf ik u omdat u moet weten dat u eeuwig leven hebt, u die gelooft in de naam van de Zoon van God.",
				true));
			vp.AddVerse(new Verse("John", 5, "24", "B-12", "Proclaim Christ", "Assurance of Salvation",
				"\"I tell you the truth, whoever hears my word and believes him who sent me has eternal life and will not be condemned; he has crossed over from death to life.\"",
				"\"Truly, truly, I say to you, whoever hears my word and believes him who sent me has eternal life. He does not come into judgment, but has passed from death to life.\"",
				"Johannes", "Waarachtig, ik verzeker u: wie luistert naar wat ik zeg en hem gelooft die mij gezonden heeft, heeft eeuwig leven; over hem wordt geen oordeel uitgesproken, hij is van de dood overgegaan naar het leven.",
				true));
			return vp;
		}

		public static VersePack C_PACK()
		{
			VersePack vp = new VersePack("");
			vp.Name = "C - Rely On God's Resources";
			vp.AddVerse(new Verse("1 Corinthians", 3, "16", "C-1", "Rely On God's Resources", "His Spirit",
				"Don't you know that you yourselves are God's temple and that God's Spirit lives in you?",
				"Do you not know that you are God's temple and that God's Spirit dwells in you?",
				"1 Korintiers", "Weet u niet dat u een tempel van God bent en dat de Geest van God in uw midden woont?",
				true));
			vp.AddVerse(new Verse("1 Corinthians", 2, "12", "C-2", "Rely On God's Resources", "His Spirit",
				"We have not received the spirit of the world but the Spirit who is from God, that we may understand what God has freely given us.",
				"Now we have received not the spirit of the world, but the Spirit who is from God, that we might understand the things freely given us by God.",
				"1 Korintiers", "Wij hebben niet de geest van de wereld ontvangen, maar de Geest die van God komt, opdat we zouden weten wat God ons in zijn goedheid heeft geschonken.",
				true));
			vp.AddVerse(new Verse("Isaiah", 41, "10", "C-3", "Rely On God's Resources", "His Strength",
				"So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand.",
				"Fear not, for I am with you; be not dismayed, for I am your God; I will strengthen you, I will help you, I will uphold you with my righteous right hand.",
				"Jesaja", "Wees niet bang, want ik ben bij je, vrees niet, want ik ben je God.  Ik zal je sterken, ik zal je helpen, je steunen met mijn onoverwinnelijke rechterhand.",
				true));
			vp.AddVerse(new Verse("Philippians", 4, "13", "C-4", "Rely On God's Resources", "His Strength",
				"I can do everything through him who gives me strength.",
				"I can do all things through him who strengthens me.",
				"Filippenzen", "Ik ben tegen alles bestand door hem die mij kracht geeft.",
				true));
			vp.AddVerse(new Verse("Lamentations", 3, "22,23", "C-5", "Rely On God's Resources", "His Faithfulness",
				"Because of the Lord's great love we are not consumed, for his compassions never fail.  They are new every morning; great is your faithfulness.",
				"The steadfast love of the Lord never ceases; his mercies never come to an end; they are new every morning; great is your faithfulness.",
				"Klaagliederen", "Genadig is de HEER: wij zijn nog in leven! Zijn ontferming kent geen grenzen.  Elke morgen schenkt hij nieuwe weldaden.  Veelvuldig blijkt uw trouw!",
				true));
			vp.AddVerse(new Verse("Numbers", 23, "19", "C-6", "Rely On God's Resources", "His Faithfulness",
				"God is not a man, that he should lie, nor a son of man, that he should change his mind. Does he speak and then not act? Does he promise and not fulfill?",
				"\"God is not man, that he should lie, or a son of man, that he should change his mind. Has he said, and will he not do it? Or has he spoken, and will he not fulfill it?\"",
				"Numeri", "God is geen mens, dat hij zijn woord zou breken of terug zou komen op zijn besluit.  Zou hij beloven en niet vervullen, zijn woord geven en het niet gestand doen?",
				true));
			vp.AddVerse(new Verse("Isaiah", 26, "3", "C-7", "Rely On God's Resources", "His Peace",
				"You will keep in perfect peace him whose mind is steadfast, because he trusts in you.",
				"\"You keep him in perfect peace whose mind is stayed on you, because he trusts in you.\"",
				"Jesaja", "De standvastige is veilig bij u, vrede is er voor wie op u vertrouwt.",
				true));
			vp.AddVerse(new Verse("1 Peter", 5, "7", "C-8", "Rely On God's Resources", "His Peace",
				"Cast all your anxiety on him because he cares for you.",
				"Casting all your anxieties on him, because he cares for you.",
				"1 Petrus", "U mag uw zorgen op hem afwentelen, want u ligt hem na aan het hart.",
				true));
			vp.AddVerse(new Verse("Romans", 8, "32", "C-9", "Rely On God's Resources", "His Provision",
				"He who did not spare his own Son, but gave him up for us all-how will he not also, along with him, graciously give us all things?",
				"He who did not spare his own Son but gave him up for us all, how will he not also with him graciously give us all things?",
				"Romeinen", "Zal hij, die zijn eigen Zoon niet heeft gespaard, maar hem omwille van ons allen heeft prijsgegeven, ons met hem niet alles schenken?",
				true));
			vp.AddVerse(new Verse("Philippians", 4, "19", "C-10", "Rely On God's Resources", "His Provision",
				"And my God will meet all your needs according to his glorious riches in Christ Jesus.",
				"And my God will supply every need of yours according to his riches in glory in Christ Jesus.",
				"Filippenzen", "Mijn God zal uit de overvloed van zijn majesteit elk tekort van u aanvullen, door Christus Jezus.",
				true));
			vp.AddVerse(new Verse("Hebrews", 2, "18", "C-11", "Rely On God's Resources", "His Help in Temptation",
				"Because he himself suffered when he was tempted, he is able to help those who are being tempted.",
				"For because he himself has suffered when tempted, he is able to help those who are being tempted.",
				"Hebreeen", "Juist omdat hij zelf op de proef werd gesteld en het lijden volbracht heeft, kan hij ieder die beproefd wordt bijstaan.",
				true));
			vp.AddVerse(new Verse("Psalm", 119, "9,11", "C-12", "Rely On God's Resources", "His Help in Temptation",
				"How can a young man keep his way pure? By living according to your word.  I have hidden your word in my heart that I might not sin against you.",
				"How can a young man keep his way pure? By guarding it according to your word. With my whole heart I seek you; let me not wander from your commandments!",
				"Psalmen", "Hoe kan wie jong is zuiver leven?  Door zich te houden aan uw woord.  Uw belofte heb ik in mijn hart geborgen, zo zal ik niet tegen u zondigen.",
				true));
			return vp;
		}

		public static VersePack D_PACK()
		{
			VersePack vp = new VersePack("");
			vp.Name = "D - Be Christ's Disciple";
			vp.AddVerse(new Verse("Matthew", 6, "33", "D-1", "Be Christ's Disciple", "Put Christ First",
				"But seek first his kingdom and his righteousness, and all these things will be given to you as well.",
				"\"But seek first the kingdom of God and his righteousness, and all these things will be added to you.\"",
				"Matteus", "Zoek liever eerst het koninkrijk van God en zijn gerechtigheid, dan zullen al die andere dingen je erbij gegeven worden.",
				true));
			vp.AddVerse(new Verse("Luke", 9, "23", "D-2", "Be Christ's Disciple", "Put Christ First",
				"Then he said to them all: \"If anyone would come after me, he must deny himself and take up his cross daily and follow me.\"",
				"And he said to all, \"If anyone would come after me, let him deny himself and take up his cross daily and follow me.\"",
				"Lucas", "Tegen allen zei hij: \"Wie achter mij aan wil komen, moet zichzelf verloochenen en dagelijks zijn kruis op zich nemen en mij volgen.\"",
				true));
			vp.AddVerse(new Verse("1 John", 2, "15,16", "D-3", "Be Christ's Disciple", "Separate From the World",
				"Do not love the world or anything in the world. If anyone loves the world, the love of the Father is not in him.  For everything in the world--the cravings of sinful man, the lust of his eyes and the boasting of what he has and does--comes not from the Father but from the world.",
				"Do not love the world or the things in the world. If anyone loves the world, the love of the Father is not in him.  For all that is in the world--the desires of the flesh and the desires of the eyes and pride in possessions--is not from the Father but is from the world.",
				"1 Johannes", "Heb de wereld en wat in de wereld is niet lief. Als iemand de wereld liefheeft, is de liefde van de Vader niet in hem, want alles wat in de wereld is - zelfzuchtige begeerte, afgunstige inhaligheid, pronkzucht -, dat alles komt niet uit de Vader voort maar uit de wereld.",
				true));
			vp.AddVerse(new Verse("Romans", 12, "2", "D-4", "Be Christ's Disciple", "Separate From the World",
				"Do not conform any longer to the pattern of this world, but be transformed by the renewing of your mind. Then you will be able to test and approve what God's will is--his good, pleasing and perfect will.",
				"Do not be conformed to this world, but be transformed by the renewal of your mind, that by testing you may discern what is the will of God, what is good and acceptable and perfect.",
				"Romeinen", "U moet uzelf niet aanpassen aan deze wereld, maar veranderen door uw gezindheid te vernieuwen, om zo te ontdekken wat God van u wil en wat goed, volmaakt en hem welgevallig is.",
				true));
			vp.AddVerse(new Verse("1 Corinthians", 15, "58", "D-5", "Be Christ's Disciple", "Be Steadfast",
				"Therefore, my dear brothers, stand firm. Let nothing move you. Always give yourselves fully to the work of the Lord, because you know that your labor in the Lord is not in vain.",
				"Therefore, my beloved brothers, be steadfast, immovable, always abounding in the work of the Lord, knowing that in the Lord your labor is not in vain.",
				"1 Korintiers", "Kortom, geliefde broeders en zusters, wees standvastig en onwankelbaar en zet u altijd volledig in voor het werk van de Heer, in het besef dat door de Heer uw inspanningen nooit tevergeefs zijn.",
				true));
			vp.AddVerse(new Verse("Hebrews", 12, "3", "D-6", "Be Christ's Disciple", "Be Steadfast",
				"Consider him who endured such opposition from sinful men, so that you will not grow weary and lose heart.",
				"Consider him who endured from sinners such hostility against himself, so that you may not grow weary or fainthearted.",
				"Hebreeen", "Laat tot u doordringen hoe hij standhield toen de zondaars zich zo tegen hem verzetten, opdat u niet de moed verliest en het opgeeft.",
				true));
			vp.AddVerse(new Verse("Mark", 10, "45", "D-7", "Be Christ's Disciple", "Serve Others",
				"\"For even the Son of Man did not come to be served, but to serve, and to give his life as a ransom for many.\"",
				"\"For even the Son of Man came not to be served but to serve, and to give his life as a ransom for many.\"",
				"Marcus", "Want ook de Mensenzoon is niet gekomen om gediend te worden, maar om te dienen en zijn leven te geven als losgeld voor velen.",
				true));
			vp.AddVerse(new Verse("2 Corinthians", 4, "5", "D-8", "Be Christ's Disciple", "Serve Others",
				"For we do not preach ourselves, but Jesus Christ as Lord, and ourselves as your servants for Jesus' sake.",
				"For what we proclaim is not ourselves, but Jesus Christ as Lord, with ourselves as your servants for Jesus' sake.",
				"2 Korintiers", "Wij verkondigen niet onszelf, wij verkondigen dat Jezus Christus de Heer is en dat wij omwille van hem uw dienaren zijn.",
				true));
			vp.AddVerse(new Verse("Proverbs", 3, "9,10", "D-9", "Be Christ's Disciple", "Give Generously",
				"Honor the Lord with your wealth, with the firstfruits of all your crops; then your barns will be filled to overflowing, and your vats will brim over with new wine.",
				"Honor the Lord with your wealth and with the firstfruits of all your produce; then your barns will be filled with plenty, and your vats will be bursting with wine.",
				"Proverbs", "Eer de HEER met al je rijkdom, met het beste van de oogst.  Graan zal je voorraadschuren vullen, je kuipen lopen over van wijn.",
				true));
			vp.AddVerse(new Verse("2 Corinthians", 9, "6,7", "D-10", "Be Christ's Disciple", "Give Generously",
				"Remember this: Whoever sows sparingly will also reap sparingly, and whoever sows generously will also reap generously.  Each man should give what he has decided in his heart to give, not reluctantly or under compulsion, for God loves a cheerful giver.",
				"The point is this: whoever sows sparingly will also reap sparingly, and whoever sows bountifully will also reap bountifully.  Each one must give as he has made up his mind, not reluctantly or under compulsion, for God loves a cheerful giver.",
				"2 Korintiers", "Bedenk dit: wie karig zaait, zal karig oogsten; wie overvloedig zaait, zal overvloedig oogsten.  Laat ieder zo veel geven als hij zelf besloten heeft, zonder tegenzin of dwang, want God heeft lief wie blijmoedig geeft.",
				true));
			vp.AddVerse(new Verse("Acts", 1, "8", "D-11", "Be Christ's Disciple", "Develop World Vision",
				"\"But you will receive power when the Holy Spirit comes on you; and you will be my witnesses in Jerusalem, and in all Judea and Samaria, and to the ends of the earth.\"",
				"\"But you will receive power when the Holy Spirit has come upon you, and you will be my witnesses in Jerusalem and in all Judea and Samaria, and to the end of the earth.\"",
				"Handelingen", "\"Maar wanneer de heilige Geest over jullie komt, zullen jullie kracht ontvangen en van mij getuigen in Jeruzalem, in heel Judea en Samaria, tot aan de uiteinden van de aarde.\"",
				true));
			vp.AddVerse(new Verse("Matthew", 28, "19,20", "D-12", "Be Christ's Disciple", "Develop World Vision",
				"\"Therefore go and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, and teaching them to obey everything I have commanded you. And surely I am with you always, to the very end of the age.\"",
				"\"Go therefore and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, teaching them to observe all that I have commanded you. And behold, I am with you always, to the end of the age.\"",
				"Matteus", "Ga dus op weg en maak alle volken tot mijn leerlingen, door hen te dopen in de naam van de Vader en de Zoon en de heilige Geest",
				true));
			return vp;
		}

		public static VersePack E_PACK()
		{
			VersePack vp = new VersePack("");
			vp.Name = "E - Grow In Christlikeness";
			vp.AddVerse(new Verse("John", 13, "34,35", "E-1", "Grow In Christlikeness", "Love",
				"\"A new command I give you: Love one another. As I have loved you, so you must love one another.  By this all men will know that you are my disciples, if you love one another.\"",
				"\"A new commandment I give to you, that you love one another: just as I have loved you, you also are to love one another.  By this all people will know that you are my disciples, if you have love for one another.\"",
				"Johannes", "\"Ik geef jullie een nieuw gebod: heb elkaar lief. Zoals ik jullie heb liefgehad, zo moeten jullie elkaar liefhebben.  Aan jullie liefde voor elkaar zal iedereen zien dat jullie mijn leerlingen zijn.\"",
				true));
			vp.AddVerse(new Verse("1 John", 3, "18", "E-2", "Grow In Christlikeness", "Love",
				"Dear children, let us not love with words or tongue but with actions and in truth.",
				"Little children, let us not love in word or talk but in deed and in truth.",
				"1 Johannes", "Kinderen, we moeten niet liefhebben met de mond, met woorden, maar waarachtig, met daden.",
				true));
			vp.AddVerse(new Verse("Philippians", 2, "3,4", "E-3", "Grow In Christlikeness", "Humility",
				"Do nothing out of selfish ambition or vain conceit, but in humility consider others better than yourselves.  Each of you should look not only to your own interests, but also to the interests of others.",
				"Do nothing from rivalry or conceit, but in humility count others more significant than yourselves.  Let each of you look not only to his own interests, but also to the interests of others.",
				"Filippenzen", "Handel niet uit geldingsdrang of eigenwaan, maar acht in alle bescheidenheid de ander belangrijker dan uzelf.  Heb niet alleen uw eigen belangen voor ogen, maar ook die van de ander.",
				true));
			vp.AddVerse(new Verse("1 Peter", 5, "5,6", "E-4", "Grow In Christlikeness", "Humility",
				"Young men, in the same way be submissive to those who are older. All of you, clothe yourselves with humility toward one another, because, \"God opposes the proud but gives grace to the humble.\"  Humble yourselves, therefore, under God's mighty hand, that he may lift you up in due time.",
				"Likewise, you who are younger, be subject to the elders. Clothe yourselves, all of you, with humility toward one another, for \"God opposes the proud but gives grace to the humble.\"  Humble yourselves, therefore, under the mighty hand of God so that at the proper time he may exalt you",
				"1 Petrus", "En u, jongeren, moet van uw kant het gezag van de oudsten erkennen. Overigens, in de omgang met elkaar moet ieder van u altijd de minste willen zijn, want God keert zich tegen hoogmoedigen, maar aan nederigen schenkt hij zijn genade.  Onderwerp u dus nederig aan Gods hoge gezag, dan zal hij u op de bestemde tijd een eervolle plaats geven.",
				true));
			vp.AddVerse(new Verse("Ephesians", 5, "3", "E-5", "Grow In Christlikeness", "Purity",
				"But among you there must not be even a hint of sexual immorality, or of any kind of impurity, or of greed, because these are improper for God's holy people.",
				"But sexual immorality and all impurity or covetousness must not even be named among you, as is proper among saints.",
				"Efeziers", "Laat er bij u geen sprake zijn van ontucht of zedeloosheid, of van hebzucht - deze dingen horen niet bij heiligen.",
				true));
			vp.AddVerse(new Verse("1 Peter", 2, "11", "E-6", "Grow In Christlikeness", "Purity",
				"Dear friends, I urge you, as aliens and strangers in the world, to abstain from sinful desires, which war against your soul.",
				"Beloved, I urge you as sojourners and exiles to abstain from the passions of the flesh, which wage war against your soul.",
				"1 Petrus", "Geliefde broeders en zusters, u bent als vreemdelingen die ver van huis zijn; ik vraag u dringend niet toe te geven aan zelfzuchtige verlangens, die uw ziel in gevaar brengen.",
				true));
			vp.AddVerse(new Verse("Leviticus", 19, "11", "E-7", "Grow In Christlikeness", "Honesty",
				"\"Do not steal.  Do not lie.  Do not deceive one another.\"",
				"\"You shall not steal; you shall not deal falsely; you shall not lie to one another.\"",
				"Leviticus", "Steel niet, lieg niet en bedrieg je naaste niet.",
				true));
			vp.AddVerse(new Verse("Acts", 24, "16", "E-8", "Grow In Christlikeness", "Honesty",
				"So I strive always to keep my conscience clear before God and man.",
				"\"So I always take pains to have a clear conscience toward both God and man.\"",
				"Handelingen", "Daarom tracht ook ik steeds mijn geweten zuiver te houden tegenover God en de mensen.",
				true));
			vp.AddVerse(new Verse("Hebrews", 1, "6", "E-9", "Grow In Christlikeness", "Faith",
				"And without faith it is impossible to please God, because anyone who comes to him must believe that he exists and that he rewards those who earnestly seek him.",
				"And without faith it is impossible to please him, for whoever would draw near to God must believe that he exists and that he rewards those who seek him.",
				"Hebreeen", "Zonder geloof is het onmogelijk God vreugde te geven; wie hem wil naderen moet immers geloven dat hij bestaat, en wie hem zoekt zal door hem worden beloond.",
				true));
			vp.AddVerse(new Verse("Romans", 4, "20,21", "E-10", "Grow In Christlikeness", "Faith",
				"Yet he did not waver through unbelief regarding the promise of God, but was strengthened in his faith and gave glory to God, being fully persuaded that God had power to do what he had promised.",
				"No distrust made him waver concerning the promise of God, but he grew strong in his faith as he gave glory to God, fully convinced that God was able to do what he had promised.",
				"Romeinen", "Hij twijfelde niet aan Gods belofte; zijn geloof verloor hij niet, integendeel, hij werd erin gesterkt en bewees zo eer aan God.  Hij was ervan overtuigd dat God bij machte was te doen wat hij had beloofd",
				true));
			vp.AddVerse(new Verse("Galatians", 6, "9,10", "E-11", "Grow In Christlikeness", "Good Works",
				"Let us not become weary in doing good, for at the proper time we will reap a harvest if we do not give up.  Therefore, as we have opportunity, let us do good to all people, especially to those who belong to the family of believers.",
				"And let us not grow weary of doing good, for in due season we will reap, if we do not give up.  So then, as we have opportunity, let us do good to everyone, and especially to those who are of the household of faith.",
				"Galaten", "Laten we daarom het goede doen, zonder op te geven, want als we niet verzwakken zullen we oogsten wanneer de tijd daarvoor gekomen is.  Laten we dus, in de tijd die ons nog rest, voor iedereen het goede doen, vooral voor onze geloofsgenoten.",
				true));
			vp.AddVerse(new Verse("Matthew", 5, "16", "E-12", "Grow In Christlikeness", "Good Works",
				"In the same way, let your light shine before men, that they may see your good deeds and praise your Father in heaven.",
				"\"In the same way, let your light shine before others, so that they may see your good works and give glory to your Father who is in heaven.\"",
				"Matteus", "Zo moet jullie licht schijnen voor de mensen, opdat ze jullie goede daden zien en eer bewijzen aan jullie Vader in de hemel.",
				true));
			return vp;
		}
	}
}
