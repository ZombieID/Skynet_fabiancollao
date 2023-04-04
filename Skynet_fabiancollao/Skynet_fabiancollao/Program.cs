
using System.Threading;

namespace Skynet_fabiancollao
{
    public partial class Program
    {
        static void Main()
        {
            while (Menu()) ;
            System.Environment.Exit(0);
        }
        static void rojo(string arg)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(arg);
            Console.ResetColor();
        }
        static void verde(string arg)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(arg);
            Console.ResetColor();
        }

        static void cyan(string args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(args);
            Console.ResetColor();
        }

        //Funcion Titulo cyan
        static void textoTitulo(string args) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(args);
            Console.ResetColor();
        }
        static void imprimirAscii()
        {

            Console.WriteLine(@"
                  wWWWNNNNNNNWww                     
             mMNX0kxdooddxxxddxk0KX               
            N0dc:;,'...';;:;''.',cox0X            
           0l;;;;,,,,,''.........;cllx0N          
          Kxc;;coxO0KOdc;,,'''''..',;okK          
         N0OdoOKN NKXXOl::cdxdddl:,';dxON         
        NOkOox    Kk0X0llodxxdxX NXOoxdlkN        
        XxdxlxNM  0xOKOodkkdxol0  MXxdo:lX        
        Nklolx   NOdko:ll:;lkolOXN Xxol,cK        
         0xxxK N0OOk0xlloodOOdkkoONNOddldX        
         KxldKXKxclxXKxoxXXNOdoccxK00OxdkN        
         O:..',:c;',lxolx0Oxc;,,:;'..,ccxN        ");
            Console.Write("        NO:. ..");
            rojo("oOo");
            Console.Write("...., oddc'...");
            rojo(":Od'");
            Console.Write(". .:o0");
            Console.WriteLine();
            Console.WriteLine(@"        MNOx:'..;c,..',lxxkoc;...;,...'cxK         
         0dooc,''';odcl:;ldO0k:''..':oldX         
         Ndlkkoc::lxl,....;oOKd:;,;;colk          
          Ocoo:,',:l:...'.'lxoc;...'c:lX          
          Ko:c,',;:dkdoldkO0Kkl:'..,lcxN          
           k:ll;,':k  NkokOX Kdc,;:lolO           
           0ool;,oddO0OdccldOOkOd:lxddON          
           Koc::cxOOOO0O0K0OO00OdlllloON          
           Nx;,:looxOkxxxxdxOkoloo:,:xN           
            Xd;:ll,cOd,'...:ko,:do;,oX            
             NKkxo,.oOc'',,lo'.:oloON             
               NKd,,x0l:cccdd,.;xKN               
                 XxdOx;',,;cddo0N                 
                   XXK0OOOOOKXN                   
                                                  "
            );
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write(@"         ____  _  ____   ___   _ _____ _____ 
        / ___|| |/ /\ \ / / \ | | ____|_   _|
        \___ \| ' /  \ V /|  \| |  _|   | |  
         ___) | . \   | | | |\  | |___  | |  
        |____/|_|\_\  |_| |_| \_|_____| |_|  ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void imprimirDespedida()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); //fondo blanco
            Thread.Sleep(100);
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine(@"                               NXK0000kdox0N     N                              
                             NXXK0xoldxl,',lk0XXOx0K0KKKX                       
                          NXXXX0xc;:;,::;'  ..;lllxxloxo::oON                   
                         NNXXX0xo:,ll.  ..      .''...'.   .c0N                 
                       NNXXXXXK0x,...                        ,ON                
                   XXXXNNXK0KXKOo.                            :K                
              NXXK0kOXNNNN0kk0XKx:,'  ....                    'xN               
             NNXK00KNNXK0KdloxKKxl:...,'..                     'kN              
            NN     M N0kxl,..:OOolc;...                         cX              
           NN   MMM  NKOd:.. .ckkkd:.                           :K              
          NNNN M     NXK0k:.  .cOx,.                            ,O              
        NXXNXKN    N  Kxdko.   .:;..                            .cK             
        NK000KX  NXNNNx;'cxo.   ...                              .dN            
         N0kOKNNNXXXNKl...:xc. ...                                ;0            
          KkOKXXXK0kxkx;...co:.                                   .k            
          NK000K0kOxldkdoc,,;:'.  ..        ...                  .oX            
            NK00kkOdoddokKkc'.',''...       ..                 .:kN             
              NKO00x:''o0OxlcldOxl:;'.                      .;oON               
               NK00Ol'.,oddxOKKOo,....                   .,lkX                  
                  NKkoc::clool:'.                   .,codOXN                    
                    NNNXNX0ko:,...        .     .. .:ON                         
                           NXkc::'..'.         .locdK                           
                             Kxdo:..;.       .,kNNN                             
                             NKkl,..,'   ..''ckN                                
                             N0d;. .,'.  .dKKXN                                 
                             NOl.  .;,.  ,0                                     
                             Xx;. .'c;.  :K                                     
                             Xd;..':o:.  :K                                     
                             Xx;.',;:;.  'k                                     
                            XOo,,;'.'.   .oN                                    
                           NOl;....''.    ,O                                    
                           0c'..  .;'      ;O                                   
                       X00Oc.....'::.      'xN                                  
                       XOdc. ...,cc.  .    .c0                                  
                        Xxo:. ...,;. .'.     ,kX                                
                        NXk;.   .,,..::.      .:kX                              
            NNN NOkX    XOl'... .'. 'dl.        .;0                             
           N0ocll..;ONX0xoc,;c' .;. .do'..   .;;',oKNNNXKX                      
       NNXK0d'.    .'ckk:.  ... ..  .:c;,'..;k0olo;',;;'.,okO0OOKN              
      NKXXK0l......'..;:....         .,coloxxxxxd;.        ......l0XN NNN       
     NNXKKKOl'....,ldollodl' ..'',;.'ldllccc:,';,.               .'lxoc:cdK     
NXXKK0OOOOkocc;;cok0kxxxko:..:ododoclxdc::;,coooo:.  .......'.   .,c:,....:dkOxx
dc;,.............'''..............................   ...   ..    ........   ...:
kl:;;,,'..                                                      ....,;;;;;;;;oOX
  NNNXXKOxc;'....  ..........'...        ...........'''''....':oxkk0XNNNNNNNN   ");//explosion
            Thread.Sleep(2000);
            Console.ResetColor() ;
            Console.Clear() ;
            /* TERMINATOR IMAGEN 1
            Console.WriteLine(@"  'loolllllllllccccccccccccccccc::;;;;;;;;:::::::::::::::::::::::::::::;;;;;;,,'.......';;.,l'.;;.  
  .collllllllccccccccccccccccccc::;;;;;;;;:::::::::::::::::::cccc:::cccc:::::;,. .;:...:xd',Od.;o;..
  .:ooolllllcccccccccccccccccccc::;;;;;;;;;:::::::::::::::::::cccccccccc:::::;,. .:dc,..lOc.o0:.ll. 
  .;ooooollllcccccccccccccccccccc::;;;;;;;;;;::::::::::::::::cccccccccccccc:::;'. ,xl...l0kl:xl.',. 
 ..,odoooolllllccccccccccccccccccc:;;;;;;;;;;;::::::::::::::cc:::;;;:;:::ccc::;,. .cdcc,cl,,'......'
 ...:oodddoolllllllccccccccccccccc:;;;;;;;;;:::::::::::::ccc:;''........',:cc::;,. .;:;....'',,,;;;:
.......,;:cllllllllllccccccccccccc::;;;;;;::::::::::::::cc:,'..',,'''''...':cc::;'...'',,;;cc::cc::c
'.....   ....,;:cllllllcccccccccccc::;;;;;:::::::::::ccccc;.'cdkO0OOkkxo:..':::;;;;;::::::::;;;,''',
:;. 'c'  ..    ..',;;:ccllccccllclcc:;;;;::::::::ccccccccc,.:k0XNNNXXKOxo;..,ccccccccccc:;...'''',,,
:c...ol......  ........',;;:cclllllcc::::::::::ccccccccclc;.:k0000000Odol;..lxdolcc:;;;,,,',,,,,,,,,
;l'..lOkdl:,'................,;;;:lllc:::::ccccccccccccccc:',:;;,',c:'.....'cc::,,,,,,''',,,,,,,,,,,
'c;..:OK00Okxdlc;,'...............',:cc:::cccccccc:::::::clcl:....;xd,....'','''',,''''''',,,,,,,,,,
.:;..,kK000OOkkkxxdol:;'.............;c::::::::::::ccclodxxxxxl:clddo:::,;:;,'''''''''''',,,,,,,,,,,
.,;'.'dKKK00OOOkkkkxxxddolc:,..  .....:dxdl:::clcclllllcc::oxddx00koc:llc;;,,'''',,,,,,,,,,,,,,,,,,,
.','..lKXKK000OOOkkkkxxxdddddl,.  ....,dKNKo;,cllool;''.'..':odxkxocc;;:c:,,'',,',,,,,,,,,,,,,,,,,,,
 .''..:0XKKK000OOOOkkkxxxxxdddo:..  ...';lxOl.;clddxl''''...';ccclol::;;;;,''''''''''''',,,,,,,,,,,;
 .''..,kXXKKKK000OOOkkkkkxxxxdddl:,. .....,lo'.,:lodd:',,''......','...'',;'''''''''''''',,,,,,,,,;;
...'...dXXKKKKK000OOOOkkkkxxxxxxdl;'...'...;c' .',,'.''',;;'.......  ....,;,''''''''''''',,,,,,,,,,;
.......cKXKKKKKK0000OOOOkkkkkxxxxdc,......';c'  ..........,'...'......   ...''''''''''''''',,,,,,,,,
,......;ONXXXKKKKK0000OOOOOkkkkxxxdo;'......,.   ........ .....',.......    ...'''''''''''''',,,,,,,
c......'xXXXXXKKKKK00000OOOOOkkkxkOKo........       ......   ...;;........     ...''''''''''''',,,,;
d,......lXXXXXKKKKKKKK00000OOOOkOKNWO:... .            ....  ...,;,..........    .............'',,,,
x:......:0NXXXXXKKKKKKKKK0000OO0XWWWKkOl...                   ..',,''..........    ....      ....',,
ko......,kNXXXXXXKKKKKKKK00000KNWMMNO0Nd....                   .''.,'.....;'......  ........ .....',
kx'.....'dXXXXXXXXKKKKKKK000KXWWMMWX0NWO,.....                 ............:'.  ..    ......  ....',
dd'......lKXXXXXXXXXXXKKKKKKXWMMMMWKKWMXl.....                  ...........,:...  .    .....  ....',");*/
            Console.WriteLine(@"                                                      ....                                          
                                                    ...,::,.                                        
                                       ..  ..  ..........',;;,'                                     
                                      .,,........';,,'......';,.                                    
                                     .':;...':odkO000Okkxo:'....                                    
                                     .;;...,:ldk0KKK00KK0Oko,.                                      
                                     ..   .';ldkOKKKKKKKK0kd:.                                      
                      ..    ...'         ...,:cclllodxdolccc;.                        .             
                     .;;.  .,',c.                    ..                                             
                      ''  .';',:.                    :c.                                            
                      ..  .cl,,;.                   ;k0l.                                           
                      ..  .cl,,;.           .......';ldd:'....                                      
                      .   .cl',;.     .    ..''';cc;....,::'..                                      
                      .   .cl'';.     ...  ....':cc:,'',col,.                                       
                           ,:;::.          ....;:'..',;;;,::.                                       
                           .,,,:.          .. .';;,,,,,,,;:,.    .                                  
                            ...,.              ...'',;::::'..  ..                                   
                             ..,.          ..    ....''''.....  .....                               
                              .;,...       ....    ...........   ..';,'.                            
                              .',..,;.      ........',,'.......    .,,..                            
                         .    ..':xoc;.     ........''''........    .:c'.                           
                               ,x0Ol'....   ........'''......'....   ':;,.                          
                               'okx:;:dxo:;;'........'......',;.   ..,'.;:,.                        
                               .:ddcokdlokK0xlc;..........',:col;..,;;'.....                        
                     .'.        .....,. .';:clol,.   .  .';oddxkx,.,',,..                           
                     ..           ..,'.';:;,.  .....  ..,:cxOkxxxc';' ....                          
                                  ..   ......  'oolc;,;coxxxkOkkkd,;'  ...     ..                   
                                               ;kkkxdlldxkxxkOkkkd::,    .                          
"); //Terminator imagen 2
            Console.ResetColor();
            Console.WriteLine(@"        _   _    _    ____ _____  _      _        _     __     _____ ____ _____  _      
       | | | |  / \  / ___|_   _|/ \    | |      / \    \ \   / /_ _/ ___|_   _|/ \     
       | |_| | / _ \ \___ \ | | / _ \   | |     / _ \    \ \ / / | |\___ \ | | / _ \    
       |  _  |/ ___ \ ___) || |/ ___ \  | |___ / ___ \    \ V /  | | ___) || |/ ___ \ _ 
       |_| |_/_/   \_\____/ |_/_/   \_\ |_____/_/   \_\    \_/  |___|____/ |_/_/   \_( )
                                                                                     |/ 
                           ____    _    ______   __
                          | __ )  / \  | __ ) \ / /
                          |  _ \ / _ \ |  _ \\ V / 
                          | |_) / ___ \| |_) || |  
                          |____/_/   \_\____/ |_|  "); //Hasta la vista...
            Thread.Sleep(5000);
        }
        static bool Menu()
        {

            bool seguir = true;
            Console.WindowWidth = 100;
            Console.WindowHeight = 43;
            Console.Clear();
            //ASCII
            imprimirAscii();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"             __________Menu__________
               1)Agregar Terminator
               2)Mostrar Terminators
               3)Buscar Terminator
               4)Destruir Skynet
              ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            Console.ResetColor();
            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarTerminator();
                    break;
                case "2": MostrarTerminator();
                    break;
                case "3": BuscarTerminator();
                    break;
                case "4": imprimirDespedida(); seguir= false;
                    break;
                default: Console.WriteLine("Ingresa bien la opción");
                    break;

            }
            return seguir;
        }
    }
}