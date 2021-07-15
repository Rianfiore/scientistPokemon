using System;
using System.IO;
using Newtonsoft.Json;
using ScientistPokemon.Entities;

namespace ScientistPokemon.Data
{
    internal class dataFiles
    {
        public static string path = "..\\ScientistPokemon\\DataFiles\\api\\v2\\", contentPath, rootPath = "/api/v2/";
        public static bool isCreated, isLoadedContents = false;
        public static string[] contents = Directory.GetDirectories(path), items;

        //public static object[] obj, obj2;
        public static void loadAllContents(){

        //obj = new object[dirs.Length];

            for (int i = 0; i < contents.Length;i++)
            {
                int count = 0, count2 = 0;
                contentPath = contents[i];
                items = Directory.GetDirectories(contentPath);
                int[] itemsInt = new int[items.Length];

                foreach (var d in items)
                {
                    try
                    {        
                    var dirName = new DirectoryInfo(d).Name;
                    itemsInt[count] = Int32.Parse(dirName);
                    count++;
                    }
                    catch {}
                }

                Array.Sort(itemsInt);
                if (isLoadedContents == false)
                {
                    isCreated = false;
                }

                for (int j = 0; j < itemsInt.Length;j++)
                {
                    verifyContent(contentPath, itemsInt[j], itemsInt.Length, count2);
                    count2++;
                }
            }

        }
        public static void verifyContent(string content, int item, int items, int count)
        {
            content = content.Remove(0,path.Length);
            switch(content)
            {
                case "ability":
                if (isCreated == false)
                {
                    Entities.Ability.MainAbility.createObject(items);
                    isCreated = true;
                }
                
                if (isLoadedContents == true)
                {
                    Entities.Ability.MainAbility.linkAllContents(count);
                }
                else
                {
                    Entities.Ability.MainAbility.setAllItems(content,item,count);
                }
                break;

                case "berry":
                if (isCreated == false)
                {
                    Entities.Berry.MainBerry.createObject(items);
                    isCreated = true;
                }
                Entities.Berry.MainBerry.setAllItems(content,item,count);
                break;

                case "berry-firmness":
                if (isCreated == false)
                {
                    Entities.BerryFirmness.MainBerryFirmness.createObject(items);
                    isCreated = true;
                }
                Entities.BerryFirmness.MainBerryFirmness.setAllItems(content,item,count);
                break;

                case "berry-flavor":
                if (isCreated == false)
                {
                    Entities.BerryFlavor.MainBerryFlavor.createObject(items);
                    isCreated = true;
                }
                Entities.BerryFlavor.MainBerryFlavor.setAllItems(content,item,count);
                break;

                case "characteristic":
                if (isCreated == false)
                {
                    Entities.Characteristic.MainCharacteristic.createObject(items);
                    isCreated = true;
                }
                Entities.Characteristic.MainCharacteristic.setAllItems(content,item,count);
                break;

                case "contest-effect":
                if (isCreated == false)
                {
                    Entities.ContestEffect.MainContestEffect.createObject(items);
                    isCreated = true;
                }
                Entities.ContestEffect.MainContestEffect.setAllItems(content,item,count);
                break;

                case "contest-type":
                if (isCreated == false)
                {
                    Entities.ContestType.MainContestType.createObject(items);
                    isCreated = true;
                }
                Entities.ContestType.MainContestType.setAllItems(content,item,count);
                break;

                case "egg-group":
                if (isCreated == false)
                {
                    Entities.EggGroup.MainEggGroup.createObject(items);
                    isCreated = true;
                }
                Entities.EggGroup.MainEggGroup.setAllItems(content,item,count);
                break;

                case "encounter-condition":
                if (isCreated == false)
                {
                    Entities.EncounterCondition.MainEncounterCondition.createObject(items);
                    isCreated = true;
                }
                Entities.EncounterCondition.MainEncounterCondition.setAllItems(content,item,count);
                break;

                case "encounter-condition-value":
                if (isCreated == false)
                {
                    Entities.EncounterConditionValue.MainEncounterConditionValue.createObject(items);
                    isCreated = true;
                }
                Entities.EncounterConditionValue.MainEncounterConditionValue.setAllItems(content,item,count);
                break;

                case "encounter-method":
                if (isCreated == false)
                {
                    Entities.EncounterMethod.MainEncounterMethod.createObject(items);
                    isCreated = true;
                }
                Entities.EncounterMethod.MainEncounterMethod.setAllItems(content,item,count);
                break;

                case "evolution-chain":
                if (isCreated == false)
                {
                    Entities.EvolutionChain.MainEvolutionChain.createObject(items);
                    isCreated = true;
                }
                Entities.EvolutionChain.MainEvolutionChain.setAllItems(content,item,count, rootPath);

                break;

                case "evolution-trigger":
                if (isCreated == false)
                {
                    Entities.EvolutionTrigger.MainEvolutionTrigger.createObject(items);
                    isCreated = true;
                }
                Entities.EvolutionTrigger.MainEvolutionTrigger.setAllItems(content,item,count);
                break;

                case "gender":
                if (isCreated == false)
                {
                    Entities.Gender.MainGender.createObject(items);
                    isCreated = true;
                }
                Entities.Gender.MainGender.setAllItems(content,item,count);
                break;

                case "generation":
                if (isCreated == false)
                {
                    Entities.Generation.MainGeneration.createObject(items);
                    isCreated = true;
                }
                Entities.Generation.MainGeneration.setAllItems(content,item,count);
                break;

                case "growth-rate":
                if (isCreated == false)
                {
                    Entities.GrowthRate.MainGrowthRate.createObject(items);
                    isCreated = true;
                }
                Entities.GrowthRate.MainGrowthRate.setAllItems(content,item,count);
                break;

                case "item":
                if (isCreated == false)
                {
                    Entities.Item.MainItem.createObject(items);
                    isCreated = true;
                }
                Entities.Item.MainItem.setAllItems(content,item,count);
                break;

                case "item-attribute":
                if (isCreated == false)
                {
                    Entities.ItemAttribute.MainItemAttribute.createObject(items);
                    isCreated = true;
                }
                Entities.ItemAttribute.MainItemAttribute.setAllItems(content,item,count);
                break;

                case "item-category":
                if (isCreated == false)
                {
                    Entities.ItemCategory.MainItemCategory.createObject(items);
                    isCreated = true;
                }
                Entities.ItemCategory.MainItemCategory.setAllItems(content,item,count);
                break;

                case "item-fling-effect":
                if (isCreated == false)
                {
                    Entities.ItemFlingEffect.MainItemFlingEffect.createObject(items);
                    isCreated = true;
                }
                Entities.ItemFlingEffect.MainItemFlingEffect.setAllItems(content,item,count);
                break;

                case "item-pocket":
                if (isCreated == false)
                {
                    Entities.ItemPocket.MainItemPocket.createObject(items);
                    isCreated = true;
                }
                Entities.ItemPocket.MainItemPocket.setAllItems(content,item,count);
                break;

                case "language":
                if (isCreated == false)
                {
                    Entities.Language.MainLanguage.createObject(items);
                    isCreated = true;
                }
                Entities.Language.MainLanguage.setAllItems(content,item,count);
                break;

                case "location":
                if (isCreated == false)
                {
                    Entities.Location.MainLocation.createObject(items);
                    isCreated = true;
                }
                Entities.Location.MainLocation.setAllItems(content,item,count);
                break;

                case "location-area":
                if (isCreated == false)
                {
                    Entities.LocationArea.MainLocationArea.createObject(items);
                    isCreated = true;
                }
                Entities.LocationArea.MainLocationArea.setAllItems(content,item,count);
                break;

                case "machine":
                if (isCreated == false)
                {
                    Entities.Machine.MainMachine.createObject(items);
                    isCreated = true;
                }
                Entities.Machine.MainMachine.setAllItems(content,item,count);
                break;

                case "move":
                if (isCreated == false)
                {
                    Entities.Move.MainMove.createObject(items);
                    isCreated = true;
                }
                Entities.Move.MainMove.setAllItems(content,item,count);
                break;

                case "move-ailment":
                if (isCreated == false)
                {
                    Entities.MoveAilment.MainMoveAilment.createObject(items);
                    isCreated = true;
                }
                Entities.MoveAilment.MainMoveAilment.setAllItems(content,item,count);
                break;

                case "move-battle-style":
                if (isCreated == false)
                {
                    Entities.MoveBattleStyle.MainMoveBattleStyle.createObject(items);
                    isCreated = true;
                }
                Entities.MoveBattleStyle.MainMoveBattleStyle.setAllItems(content,item,count);
                break;

                case "move-category":
                if (isCreated == false)
                {
                    Entities.MoveCategory.MainMoveCategory.createObject(items);
                    isCreated = true;
                }
                Entities.MoveCategory.MainMoveCategory.setAllItems(content,item,count);
                break;

                case "move-damage-class":
                if (isCreated == false)
                {
                    Entities.MoveDamageClass.MainMoveDamageClass.createObject(items);
                    isCreated = true;
                }
                Entities.MoveDamageClass.MainMoveDamageClass.setAllItems(content,item,count);
                break;

                case "move-learn-method":
                if (isCreated == false)
                {
                    Entities.MoveLearnMethod.MainMoveLearnMethod.createObject(items);
                    isCreated = true;
                }
                Entities.MoveLearnMethod.MainMoveLearnMethod.setAllItems(content,item,count);
                break;

                case "move-target":
                if (isCreated == false)
                {
                    Entities.MoveTarget.MainMoveTarget.createObject(items);
                    isCreated = true;
                }
                Entities.MoveTarget.MainMoveTarget.setAllItems(content,item,count);
                break;

                case "nature":
                if (isCreated == false)
                {
                    Entities.Nature.MainNature.createObject(items);
                    isCreated = true;
                }
                Entities.Nature.MainNature.setAllItems(content,item,count);
                break;

                case "pal-park-area":
                if (isCreated == false)
                {
                    Entities.PalParkArea.MainPalParkArea.createObject(items);
                    isCreated = true;
                }
                Entities.PalParkArea.MainPalParkArea.setAllItems(content,item,count);
                break;

                case "pokeathlon-stat":
                if (isCreated == false)
                {
                    Entities.PokeathlonStat.MainPokeathlonStat.createObject(items);
                    isCreated = true;
                }
                Entities.PokeathlonStat.MainPokeathlonStat.setAllItems(content,item,count);
                break;

                case "pokedex":
                if (isCreated == false)
                {
                    Entities.Pokedex.MainPokedex.createObject(items);
                    isCreated = true;
                }
                Entities.Pokedex.MainPokedex.setAllItems(content,item,count);
                break;

                case "pokemon":
                if (isCreated == false)
                {
                    Entities.Pokemon.MainPokemon.createObject(items);
                    isCreated = true;
                }
            
                if (isLoadedContents == true)
                {
                    Entities.Pokemon.MainPokemon.linkAllContents(count);
                }
                else
                {
                    Entities.Pokemon.MainPokemon.setAllItems(content,item,count);
                }
                break;
                
                case "pokemon-color":
                if (isCreated == false)
                {
                    Entities.PokemonColor.MainPokemonColor.createObject(items);
                    isCreated = true;
                }
                 Entities.PokemonColor.MainPokemonColor.setAllItems(content,item,count);
                break;

                case "pokemon-form":
                if (isCreated == false)
                {
                     Entities.PokemonForm.MainPokemonForm.createObject(items);
                    isCreated = true;
                }
                 Entities.PokemonForm.MainPokemonForm.setAllItems(content,item,count);
                break;

                case "pokemon-habitat":
                if (isCreated == false)
                {
                     Entities.PokemonHabitat.MainPokemonHabitat.createObject(items);
                    isCreated = true;
                }
                 Entities.PokemonHabitat.MainPokemonHabitat.setAllItems(content,item,count);
                break;

                case "pokemon-shape":
                if (isCreated == false)
                {
                     Entities.PokemonShape.MainPokemonShape.createObject(items);
                    isCreated = true;
                }
                 Entities.PokemonShape.MainPokemonShape.setAllItems(content,item,count);
                break;

                case "pokemon-species":
                if (isCreated == false)
                {
                    Entities.PokemonSpecies.MainPokemonSpecies.createObject(items);
                    isCreated = true;
                }
                Entities.PokemonSpecies.MainPokemonSpecies.setAllItems(content,item,count);
                break;

                case "region":
                if (isCreated == false)
                {
                    Entities.Region.MainRegion.createObject(items);
                    isCreated = true;
                }
                Entities.Region.MainRegion.setAllItems(content,item,count);
                break;

                case "stat":
                if (isCreated == false)
                {
                     Entities.Stat.MainStat.createObject(items);
                    isCreated = true;
                }

                if (isLoadedContents == true)
                {
                    Entities.Stat.MainStat.linkAllContents(count, rootPath);
                }
                else
                {
                    Entities.Stat.MainStat.setAllItems(content,item,count);
                }
                break;

                case "super-contest-effect":
                if (isCreated == false)
                {
                    Entities.SuperContestEffect.MainSuperContestEffect.createObject(items);
                    isCreated = true;
                }
                 Entities.SuperContestEffect.MainSuperContestEffect.setAllItems(content,item,count);
                break;

                case "type":
                if (isCreated == false)
                {
                    Entities.Type.MainType.createObject(items);
                    isCreated = true;
                }
                Entities.Type.MainType.setAllItems(content,item,count);
                break;

                case "version":
                if (isCreated == false)
                {
                    Entities.Version.MainVersion.createObject(items);
                    isCreated = true;
                }
                Entities.Version.MainVersion.setAllItems(content,item,count);
                break;

                case "version-group":
                if (isCreated == false)
                {
                   Entities.VersionGroup.MainVersionGroup.createObject(items);
                    isCreated = true;
                }
                Entities.VersionGroup.MainVersionGroup.setAllItems(content,item,count);
                break;

                default:
                break;
            }
        }
    }
}