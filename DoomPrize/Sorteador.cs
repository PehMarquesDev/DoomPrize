using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomPrize
{
    public class Sorteador
    {
        public int Sorteio(int tipoLoot, Random random)
        {
            try
            {
                var numero = 0.0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Ex. Mochilas = 5/7 = 0,714 -> Porcentagem real. 

                // O sorteio de itens com variação será feito a parte com suas respectivas porcentagens.
                // Como os tipos de mochila, armas melee e armas de fogo.

                if (tipoLoot == 1) // Loot Raro
                {
                    numero = random.NextDouble() * 8.744;
                    if (numero < 1.917) // Armas de fogo
                    {
                        return 1;
                    }
                    else if (numero > 1.916 && numero < 4.083) // Armas Melee lvl 1
                    {
                        return 2;
                    }
                    else if (numero > 4.082 && numero < 5.749) // Armas Melee lvl 2
                    {
                        return 3;
                    }
                    else if (numero > 5.748 && numero < 6.832) // Armas Melee lvl 3
                    {
                        return 4;
                    }
                    else if (numero > 6.831 && numero < 7.498) // Armas Melee lvl 4
                    {
                        return 5;
                    }
                    else if (numero > 7.497 && numero < 7.831) // Armas Melee lvl 5
                    {
                        return 6;
                    }
                    else if (numero > 7.830 && numero < 7.997) // Armas Melee lvl Lendário
                    {
                        return 7;
                    }
                    else if (numero > 7.996 && numero < 8.413) // Mochilas Vip
                    {
                        return 8;
                    }
                    else if (numero > 8.412 && numero < 8.496) // Vipbox ANT
                    {
                        return 9;
                    }
                    else if (numero > 8.495 && numero < 8.571) // Vipbox COCK
                    {
                        return 10;
                    }

                    else if (numero > 8.570 && numero < 8.637) // Vipbox DRAGON
                    {
                        return 11;
                    }

                    else if (numero > 8.636 && numero <= 8.744) // Vipbox DOOM
                    {
                        return 12;
                    }
                    else
                    {
                        return 0;
                    }

                }
                else if (tipoLoot == 2) // Loot Épico
                {
                    numero = random.NextDouble() * 8.539;
                    if (numero < 2.091) // Armas de fogo
                    {
                        return 1;
                    }
                    else if (numero > 2.090 && numero < 3.909) // Armas Melee lvl 2
                    {
                        return 3;
                    }
                    else if (numero > 3.908 && numero < 5.090) // Armas Melee lvl 3
                    {
                        return 4;
                    }
                    else if (numero > 5.089 && numero < 5.817) // Armas Melee lvl 4
                    {
                        return 5;
                    }
                    else if (numero > 5.816 && numero < 6.544) // Armas Melee lvl 5
                    {
                        return 6;
                    }
                    else if (numero > 6.543 && numero < 6.907) // Armas Melee lvl Lendário
                    {
                        return 7;
                    }
                    else if (numero > 6.906 && numero < 7.816) // Mochilas Vip
                    {
                        return 8;
                    }
                    else if (numero > 7.815 && numero < 7.997) // Vipbox ANT
                    {
                        return 9;
                    }
                    else if (numero > 7.996 && numero < 8.178) // Vipbox COCK
                    {
                        return 10;
                    }

                    else if (numero > 8.177 && numero < 8.359) // Vipbox DRAGON
                    {
                        return 11;
                    }

                    else if (numero > 8.358 && numero <= 8.539) // Vipbox DOOM
                    {
                        return 12;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (tipoLoot == 3) // Loot Lendário
                {
                    numero = random.NextDouble() * 7.329;
                    if (numero < 1.445) // Armas Melee lvl 3
                    {
                        return 4;
                    }
                    else if (numero > 1.444 && numero < 2.333) // Armas Melee lvl 4
                    {
                        return 5;
                    }
                    else if (numero > 2.332 && numero < 3.666) // Armas Melee lvl 5
                    {
                        return 6;
                    }
                    else if (numero > 3.665 && numero < 4.332) // Armas Melee lvl Lendário
                    {
                        return 7;
                    }
                    else if (numero > 4.331 && numero < 5.998) // Mochilas Vip
                    {
                        return 8;
                    }
                    else if (numero > 5.997 && numero < 6.331) // Vipbox ANT
                    {
                        return 9;
                    }
                    else if (numero > 6.330 && numero < 6.664) // Vipbox COCK
                    {
                        return 10;
                    }

                    else if (numero > 6.663 && numero < 6.997) // Vipbox DRAGON
                    {
                        return 11;
                    }

                    else if (numero > 6.996 && numero <= 7.329) // Vipbox DOOM
                    {
                        return 12;
                    }
                    else
                    {
                        return 0;
                    }
                }

                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public Premios SorteioMochila(Random random)
        {
            try
            {
                var premio = new Premios();
                var nome = string.Empty;
                var numero = 0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Nesse caso, 7 tipos de mochila vip (mochilas doom variadas)
                // sorteio aleatório de 1 a 4, 25% de chance pra cada mochila

                numero = random.Next(1,5);
                if (numero == 1) // ANT
                {
                    premio.Nome = "Mochila ANT";
                    premio.Imagem = Properties.Resources.MochilaAnt;
                    return premio;
                }
                else if (numero == 2) // COCKROACH
                {
                    premio.Nome = "Mochila COCKROACH";
                    premio.Imagem = Properties.Resources.MochilaCockroach;
                    return premio;
                }
                else if (numero == 3) // DRAGONFLY
                {
                    premio.Nome = "Mochila DRAGONFLY";
                    premio.Imagem = Properties.Resources.MochilaDragonfly;
                    return premio;
                }
                else if (numero == 4) // DOOM
                {
                    premio.Nome = "Mochila DOOM";
                    return premio;
                }
                else
                {
                    return premio;
                }
            }
            catch (Exception)
            {

                return new Premios();
            }
        }

        public Premios SorteioMochilaDoom(Random random)
        {
            try
            {
                var premio = new Premios();
                var nome = string.Empty;
                var numero = 0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Nesse caso, 4 tipos de mochila DOOM (cores)
                // sorteio aleatório de 1 a 4, 25% de chance pra cada mochila

                numero = random.Next(1, 5);
                if (numero == 1) // RED
                {
                    premio.Nome = "Mochila Doom";
                    premio.Lvl = "1";
                    premio.Imagem = Properties.Resources.MochilaDoomRed;
                    return premio;
                }
                else if (numero == 2) // GOLD
                {
                    premio.Nome = "Mochila Doom";
                    premio.Lvl = "2";
                    premio.Imagem = Properties.Resources.MochilaDoomGold;
                    return premio;
                }
                else if (numero == 3) // BLACK
                {
                    premio.Nome = "Mochila Doom";
                    premio.Lvl = "3";
                    premio.Imagem = Properties.Resources.MochilaDoomBlack;
                    return premio;
                }
                else if (numero == 4) // WHITE
                {
                    premio.Nome = "Mochila Doom";
                    premio.Lvl = "4";
                    premio.Imagem = Properties.Resources.MochilaDoomWhite;
                    return premio;
                }
                else
                {
                    return premio;
                }
            }
            catch (Exception)
            {

                return new Premios();
            }
        }

        public Premios SorteioArmaMelee(int tipoLoot, int lvl, Random random)
        {
            try
            {
                var premio = new Premios();
                switch (lvl)
                {
                    case 2:
                        premio.Lvl = "1";
                        break;
                    case 3:
                        premio.Lvl = "2";
                        break;
                    case 4:
                        premio.Lvl = "3";
                        break;
                    case 5:
                        premio.Lvl = "4";
                        break;
                    case 6:
                        premio.Lvl = "5";
                        break;
                    case 7:
                        premio.Lvl = "LENDARIO";
                        break;
                }                

                var nome = string.Empty;
                var numero = 0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Nesse caso, 6 tipos de Armas melee
                // Sorteio aleatório de 1 a 6, 16,6% de chance pra cada arma
                if (tipoLoot == 1)
                {
                    numero = random.Next(1, 7);
                    if (numero == 1) // MACHADO
                    {
                        premio.Nome = "Machado";
                        premio.Imagem = Properties.Resources.Machado;
                        return premio;
                    }
                    else if (numero == 2) // FACA DE CAÇA
                    {
                        premio.Nome = "Faca de caca";
                        premio.Imagem = Properties.Resources.FacaCaca;
                        return premio;
                    }
                    else if (numero == 3) // TACO DE BASEBALL
                    {
                        premio.Nome = "Taco de Baseball";
                        premio.Imagem = Properties.Resources.TacoBaseball;
                        return premio;
                    }
                    else if (numero == 4) // PÉ DE CABRA
                    {
                        premio.Nome = "Pe de Cabra";
                        premio.Imagem = Properties.Resources.Crowbar;
                        return premio;
                    }
                    else if (numero == 5) // MACHETE
                    {
                        premio.Nome = "Machete";
                        premio.Imagem = Properties.Resources.Machete;
                        return premio;
                    }
                    else if (numero == 6) // KATANA
                    {
                        premio.Nome = "Katana";
                        premio.Imagem = Properties.Resources.Katana;
                        return premio;
                    }
                    else
                    {
                        return premio;
                    }
                }

                else if (tipoLoot == 2)
                {
                    numero = random.Next(1, 11);
                    if (numero < 3) // MACHADO
                    {
                        premio.Nome = "Machado";
                        premio.Imagem = Properties.Resources.Machado;
                        return premio;
                    }
                    else if (numero == 3) // FACA DE CAÇA
                    {
                        premio.Nome = "Faca de caca";
                        premio.Imagem = Properties.Resources.FacaCaca;
                        return premio;
                    }
                    else if (numero > 3 && numero < 6) // TACO DE BASEBALL
                    {
                        premio.Nome = "Taco de Baseball";
                        premio.Imagem = Properties.Resources.TacoBaseball;
                        return premio;
                    }
                    else if (numero == 6) // PÉ DE CABRA
                    {
                        premio.Nome = "Pe de Cabra";
                        premio.Imagem = Properties.Resources.Crowbar;
                        return premio;
                    }
                    else if (numero > 6 && numero < 9) // MACHETE
                    {
                        premio.Nome = "Machete";
                        premio.Imagem = Properties.Resources.Machete;
                        return premio;
                    }
                    else if (numero > 8) // KATANA
                    {
                        premio.Nome = "Katana";
                        premio.Imagem = Properties.Resources.Katana;
                        return premio;
                    }
                    else
                    {
                        return premio;
                    }
                }

                else
                {
                    numero = random.Next(1, 13);
                    if (numero <= 3) // MACHADO
                    {
                        premio.Nome = "Machado";
                        premio.Imagem = Properties.Resources.Machado;
                        return premio;
                    }
                    else if (numero > 3 && numero < 5) // TACO DE BASEBALL
                    {
                        premio.Nome = "Taco de Baseball";
                        premio.Imagem = Properties.Resources.TacoBaseball;
                        return premio;
                    }
                    else if (numero == 5) // PÉ DE CABRA
                    {
                        premio.Nome = "Pe de Cabra";
                        premio.Imagem = Properties.Resources.Crowbar;
                        return premio;
                    }
                    else if (numero > 5 && numero < 9) // MACHETE
                    {
                        premio.Nome = "Machete";
                        premio.Imagem = Properties.Resources.Machete;
                        return premio;
                    }
                    else if (numero > 8) // KATANA
                    {
                        premio.Nome = "Katana";
                        premio.Imagem = Properties.Resources.Katana;
                        return premio;
                    }
                    else
                    {
                        return premio;
                    }
                }

            }
            catch (Exception)
            {

                return new Premios();
            }
        }

        public Premios SorteioArmaFogo(Random random)
        {
            try
            {

                var premio = new Premios();
                var nome = string.Empty;
                var numero = 0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Nesse caso, 7 tipos de Armas de fogo
                // Sorteio aleatório de 1 a 7, 14,2% de chance pra cada arma

                numero = random.Next(1, 8);
                if (numero == 1) // M82
                {
                    premio.Nome = "M82";
                    premio.Imagem = Properties.Resources.M82;
                    return premio;
                }
                else if (numero == 2) // M14
                {
                    premio.Nome = "M14";
                    premio.Imagem = Properties.Resources.M14;
                    return premio;
                }
                else if (numero == 3) // M16A1
                {
                    premio.Nome = "M16A1";
                    premio.Imagem = Properties.Resources.M16A1;
                    return premio;
                }
                else if (numero == 4) // SCARH
                {
                    premio.Nome = "SCARH";
                    premio.Imagem = Properties.Resources.SCARH;
                    return premio;
                }
                else if (numero == 5) // AK47
                {
                    premio.Nome = "AK47";
                    premio.Imagem = Properties.Resources.AK47;
                    return premio;
                }
                else if (numero == 6) // AK103
                {
                    premio.Nome = "AK103";
                    premio.Imagem = Properties.Resources.AK103;
                    return premio;
                }
                else if (numero == 7) // AK74
                {
                    premio.Nome = "AK74";
                    premio.Imagem = Properties.Resources.AK47;
                    return premio;
                }
                else
                {
                    return premio;
                }
            }
            catch (Exception)
            {

                return new Premios();
            }
        }

        public Premios SorteioSetDoom(Random random)
        {
            try
            {

                var premio = new Premios();
                var nome = string.Empty;
                var numero = 0;
                //var random = new Random();

                // Porcentagens caluladas pela amostragem de itens e suas respectivas porcentagens.
                // Valor da porcentagem dividido pelo total de itens.
                // Nesse caso, 4 tipos de Cores de set Doom
                // Sorteio aleatório de 1 a 4, 25% de chance pra cada arma

                numero = random.Next(1, 5);
                if (numero == 1) // Doom Red
                {
                    premio.Nome = "Vipbox Doom";
                    premio.Lvl = "1";
                    premio.Imagem = Properties.Resources.VipboxDoomRed;
                    return premio;
                }
                else if (numero == 2) // Doom Gold
                {
                    premio.Nome = "Vipbox Doom";
                    premio.Lvl = "2";
                    premio.Imagem = Properties.Resources.VipboxDoomGold;
                    return premio;
                }
                else if (numero == 3) // Doom Black
                {
                    premio.Nome = "Vipbox Doom";
                    premio.Lvl = "3";
                    premio.Imagem = Properties.Resources.VipboxDoomBlack;
                    return premio;
                }
                else if (numero == 4) // Doom White
                {
                    premio.Nome = "Vipbox Doom";
                    premio.Lvl = "4";
                    premio.Imagem = Properties.Resources.VipboxDoomWhite;
                    return premio;
                }
                else
                {
                    return premio;
                }
            }
            catch (Exception)
            {

                return new Premios();
            }
        }
    }
}
