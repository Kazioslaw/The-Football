using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;
using System.Security.Claims;

namespace TfcDomain.Models
{
    public class PlayerAttributeSet : Entity
    {
        [Required]
        [ForeignKey(nameof(Player))]
        public int PlayerID { get; set; }

        public byte Acceleration { get; set; }
        public byte Adaptability { get; set; }
        public byte Aggression { get; set; }
        public byte Agility { get; set; }
        public byte Ambition { get; set; }
        public byte Anticipation { get; set; }
        public byte ArealReach { get; set; }
        public byte Balance { get; set; }
        public byte Bravery { get; set; }
        public byte CommandOfArea { get; set; }
        public byte Communication { get; set; }
        public byte Composure { get; set; }
        public byte Concentration { get; set; }
        public byte Consistency { get; set; }
        public byte Controversy { get; set; }
        public byte Corners { get; set; }
        public byte Crossing { get; set; }
        public byte Decisions { get; set; }
        public byte Determination { get; set; }
        public byte Dirtiness { get; set; }
        public byte Dribbling { get; set; }
        public byte Eccentricity { get; set; }
        public byte Finishing { get; set; }
        public byte FirstTouch { get; set; }
        public byte Flair { get; set; }
        public byte FreeKickTaking { get; set; }
        public byte Handling { get; set; }
        public byte Heading { get; set; }
        public byte ImportantMatches { get; set; }
        public byte InjuryProneness { get; set; }
        public byte JumpingReach { get; set; }
        public byte Kicking { get; set; }
        public byte Leadership { get; set; }
        public byte LongShots { get; set; }
        public byte LongThrows { get; set; }
        public byte Loyality { get; set; }
        public byte Marking { get; set; }
        public byte NaturalFitness { get; set; }
        public byte OffTheBall { get; set; }
        public byte OneOnOnes { get; set; }
        public byte Pace { get; set; }
        public byte Passing { get; set; }
        public byte PenaltyTaking { get; set; }
        public byte Positioning { get; set; }
        public byte Pressure { get; set; }
        public byte Professionalism { get; set; }
        public byte Reflex { get; set; }
        public byte RushingOut { get; set; }
        public byte Sportmanship { get; set; }
        public byte Stamina { get; set; }
        public byte Strength { get; set; }
        public byte Tackling { get; set; }
        public byte Teamwork { get; set; }
        public byte Technique { get; set; }
        public byte Temperament { get; set; }
        public byte Throwing { get; set; }
        public byte TrendToPunch { get; set; }
        public byte Versatility { get; set; }
        public byte Vision { get; set; }
        public byte WorkRate { get; set; }
        public DateTime LastUpdate { get; set; }

        private Player Player { get; set; }

        public void SetAttrubutesGoalkeeper(int playerId, DateTime lastUpdate, byte agility, byte anticipation,
                                             byte arealReach, byte commandOfArea, byte communication, byte concentration,
                                             byte decisions, byte handling, byte kicking, byte oneOnOnes,
                                             byte positioning, byte reflex, byte throwing)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Agility = agility;
            Anticipation = anticipation;
            ArealReach = arealReach;
            CommandOfArea = commandOfArea;
            Communication = communication;
            Concentration = concentration;
            Decisions = decisions;
            Handling = handling;
            Kicking = kicking;
            OneOnOnes = oneOnOnes;
            Positioning = positioning;
            Reflex = reflex;
            Throwing = throwing;
        }

        public void SetAttrubitesDefenderRightLeft(int playerId, DateTime lastUpdate, byte anticipation, byte composure,
                                                    byte concentration, byte crossing, byte decisions, byte marking,
                                                    byte pace, byte passing, byte positioning, byte stamina,
                                                    byte tackling, byte teamwork)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Anticipation = anticipation;
            Composure = composure;
            Concentration = concentration;
            Crossing = crossing;
            Decisions = decisions;
            Marking = marking;
            Pace = pace;
            Passing = passing;
            Positioning = positioning;
            Stamina = stamina;
            Tackling = tackling;
            Teamwork = teamwork;
        }

        public void SetAttrubitesDefenderCentre(int playerId, DateTime lastUpdate, byte aggression, byte anticipation,
                                                 byte bravery, byte composure, byte concentration, byte decisions,
                                                 byte heading, byte jumpingReach, byte marking, byte pace,
                                                 byte positioning, byte strength, byte tackling)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Aggression = aggression;
            Anticipation = anticipation;
            Bravery = bravery;
            Composure = composure;
            Concentration = concentration;
            Decisions = decisions;
            Heading = heading;
            JumpingReach = jumpingReach;
            Marking = marking;
            Pace = pace;
            Positioning = positioning;
            Strength = strength;
            Tackling = tackling;

        }

        public void SetAttrubitesWingBackRightLeft(int playerId, DateTime lastUpdate, byte acceleration, byte agility,
                                                   byte anticipation, byte concentration, byte crossing, byte decisions,
                                                   byte dribbling, byte firstTouch, byte marking, byte offTheBall,
                                                   byte pace, byte passing, byte positioning, byte stamina,
                                                   byte tackling, byte teamwork, byte technique, byte workRate)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Acceleration = acceleration;
            Agility = agility;
            Anticipation = anticipation;
            Concentration = concentration;
            Crossing = crossing;
            Decisions = decisions;
            Dribbling = dribbling;
            FirstTouch = firstTouch;
            Marking = marking;
            OffTheBall = offTheBall;
            Pace = pace;
            Passing = passing;
            Positioning = positioning;
            Stamina = stamina;
            Tackling = tackling;
            Teamwork = teamwork;
            Technique = technique;
            WorkRate = workRate;
        }

        public void SetAttrubitesDefensiveMidfielder(int playerId, DateTime lastUpdate, byte aggression, byte anticipation,
                                                     byte composure, byte concentration, byte decisions, byte marking,
                                                     byte passing, byte positioning, byte stamina, byte strength,
                                                     byte tackling, byte teamwork, byte workRate)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Aggression = aggression;
            Anticipation = anticipation;
            Composure = composure;
            Concentration = concentration;
            Decisions = decisions;
            Marking = marking;
            Passing = passing;
            Positioning = positioning;
            Stamina = stamina;
            Strength = strength;
            Tackling = tackling;
            Teamwork = teamwork;
            WorkRate = workRate;
        }

        public void SetAttrubitesMidfielderRightLeft(int playerId, DateTime lastUpdate, byte acceleration, byte agility,
                                                     byte anticipation, byte concentration, byte crossing, byte decisions,
                                                     byte dribbling, byte firstTouch, byte marking, byte offTheBall,
                                                     byte pace, byte passing, byte positioning, byte stamina,
                                                     byte tackling, byte teamwork, byte technique, byte workRate)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Acceleration = acceleration;
            Agility = agility;
            Anticipation = anticipation;
            Concentration = concentration;
            Crossing = crossing;
            Decisions = decisions;
            Dribbling = dribbling;
            FirstTouch = firstTouch;
            Marking = marking;
            OffTheBall = offTheBall;
            Pace = pace;
            Passing = passing;
            Positioning = positioning;
            Stamina = stamina;
            Tackling = tackling;
            Teamwork = teamwork;
            Technique = technique;
            WorkRate = workRate;

        }

        public void SetAttrubitesMidfielderCentre(int playerId, DateTime lastUpdate, byte anticipation, byte composure,
                                                  byte concentration, byte decisions, byte firstTouch, byte offTheBall,
                                                  byte passing, byte stamina, byte tackling, byte teamwork,
                                                  byte techniquie, byte vision, byte workRate)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Anticipation = anticipation;
            Composure = composure;
            Concentration = concentration;
            Decisions = decisions;
            FirstTouch = firstTouch;
            OffTheBall = offTheBall;
            Passing = passing;
            Stamina = stamina;
            Tackling = tackling;
            Teamwork = teamwork;
            Technique = techniquie;
            Vision = vision;
            WorkRate = workRate;
        }

        public void SetAttrubitesAttackingMidfielderRightLeft(int playerId, DateTime lastUpdate, byte acceleration, byte agility,
                                                              byte anticipation, byte crossing, byte dribbling, byte firstTouch,
                                                              byte flair, byte offTheBall, byte pace, byte passing, byte technique)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Acceleration = acceleration;
            Agility = agility;
            Anticipation = anticipation;
            Crossing = crossing;
            Dribbling = dribbling;
            FirstTouch = firstTouch;
            Flair = flair;
            OffTheBall = offTheBall;
            Pace = pace;
            Passing = passing;
            Technique = technique;
        }

        public void SetAttrubitesAttackingMidfielderCentre(int playerId, DateTime lastUpdate, byte agility, byte anticipation,
                                                           byte composure, byte decisions, byte dribbling, byte finishing,
                                                           byte firstTouch, byte flair, byte longShots, byte offTheBall,
                                                           byte passing, byte technique, byte vision)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Agility = agility;
            Anticipation = anticipation;
            Composure = composure;
            Decisions = decisions;
            Dribbling = dribbling;
            Finishing = finishing;
            FirstTouch = firstTouch;
            Flair = flair;
            LongShots = longShots;
            OffTheBall = offTheBall;
            Passing = passing;
            Technique = technique;
            Vision = vision;

        }

        public void SetAttrubitesStrikerCentre(int playerId, DateTime lastUpdate, byte acceleration, byte agility,
                                               byte anticipation, byte balance, byte composure, byte decisions,
                                               byte dribbling, byte finishing, byte firstTouch, byte offTheBall,
                                               byte pace, byte passing, byte stamina, byte technique, byte workRate)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Acceleration = acceleration;
            Agility = agility;
            Anticipation = anticipation;
            Balance = balance;
            Composure = composure;
            Decisions = decisions;
            Dribbling = dribbling;
            Finishing = finishing;
            FirstTouch = firstTouch;
            OffTheBall = offTheBall;
            Pace = pace;
            Passing = passing;
            Stamina = stamina;
            Technique = technique;
            WorkRate = workRate;
        }
        public void SetAttributeGeneral(int playerId, DateTime lastUpdate, byte corners, byte determination, byte freeKickTaking, byte penaltyTaking)
        {
            PlayerID = playerId;
            LastUpdate = lastUpdate;
            Corners = corners;
            Determination = determination;
            FreeKickTaking = freeKickTaking;
            PenaltyTaking = penaltyTaking;
        }
    }
}
