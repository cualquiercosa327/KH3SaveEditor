﻿/*
    Kingdom Hearts 0.2 and 3 Save Editor
    Copyright (C) 2019  Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave.Types
{
	public enum CommandType : int
	{
		Empty_Dash = 0x0,
		Empty_1 = 0x1,
		PaybackStrike = 0x2,
		CounterSlash = 0x3,
		CounterImpact = 0x4,
		CounterKick = 0x5,
		CounterBlast = 0x6,
		RisingHook = 0x7,
		RiskRaid = 0x8,
		Backslash = 0x9,
		TeleportSlash = 0xa,
		DivingStrike = 0xb,
		FinalBlow = 0xc,
		Raid = 0xd,
		NanoCounter = 0xe,
		CounterBlade = 0xf,
		WrathfulFist = 0x10,
		WrathfulFlurry = 0x11,
		FlameTorrent = 0x12,
		FlameBarrage = 0x13,
		Lightning = 0x14,
		Sneeze = 0x15,
		UnisonFire = 0x16,
		UnisonBlizzard = 0x17,
		UnisonThunder = 0x18,
		FusionSpin = 0x19,
		FusionRocket = 0x1a,
		Attack = 0x1b,
		Empty_1C = 0x1c,
		[Magic] Fire = 0x1d,
		[Magic] Fira = 0x1e,
		[Magic] Firaga = 0x1f,
		[Magic] Firaza = 0x20,
		[Magic] Blizzard,
		[Magic] Blizzara,
		[Magic] Blizzaga,
		[Magic] Blizzaza,
		[Magic] Thunder,
		[Magic] Thundara,
		[Magic] Thundaga,
		[Magic] Thundaza,
		[Magic] Water,
		[Magic] Watera,
		[Magic] Waterga,
		[Magic] Waterza,
		[Magic] Aero,
		[Magic] Aerora,
		[Magic] Aeroga = 0x2f,
		[Magic] Aeroza,
		[Magic] Cure,
		[Magic] Cura,
		[Magic] Curaga,
		[Magic] Curaza,
		[Magic("Sea-Fire")] SeaFire,
		[Magic("Sea-Blizzard")] SeaBlizzard,
		[Magic("Sea-Thunder")] SeaThunder,
		[Magic("Sea-Aero")] SeaAero,
		[Consumable("Potion")] Potion = 0x3a,
		[Consumable("Hi-Potion")] HiPotion,
		[Consumable("Mega-Potion")] MegaPotion,
		[Consumable("Ether")] Ether,
		[Consumable("Hi-Ether")] HiEther,
		[Consumable("Mega-Ether")] MegaEther,
		[Consumable("Refocuser")] Refocuser,
		[Consumable("Hi-Refocuser")] HiRefocuser,
		[Consumable("Panacea")] Panacea,
		Unused45,
		Unused46,
		Unused47,
		[Link("Meow Wow Balloon")] MeowWowBaloon,
		[Link("8-Bit Blast")] EightBitBlast,
		[Link("King's Flare")] KingFlare,
		[Link("Plasma Encounter")] PlasmaEncounter,
		[Link("Sea Spectacle")] SeaSpectacle,
		Finish,
		Save,
		Talk,
		Open,
		Examine,
		Shop,
		Help,
		Board,
		TakeTheHelm,
		Ride,
		Eject,
		MagAssemble,
		GetOn,
		Ride_58,
		CoverShot,
		CoverSlide,
		Perform,
		Splash,
		ReachOut,
		Board_5E,
		RagingCannons,
		WindChasers,
		TidalWave,
		Tailwind,
		Swing,
		Boinnng,
		Empty_65,
		SendPostcard,
		ChooseVitality,
		ChooseWisdom,
		ChooseBalance,
		ChooseTheWarrior,
		ChooseTheMystic,
		ChooseTheGuardian,
		ReturnToTheLight,
        [Magic("Fira")] Fira_6E,
        [Magic("Firaga")] Firaga_6F,
        [Magic("Firaza")] Firaza_70,
        [Magic("Blizzara")] Blizzara_71,
        [Magic("Blizzaga")] Blizzaga_72,
        [Magic("Blizzaza")] Blizzaza_73,
        [Magic("Thundara")] Thundara_74,
        [Magic("Thundaga")] Thundaga_75,
        [Magic("Thundaza")] Thundaza_76,
        [Magic("Watera")] Watera_77,
        [Magic("Waterga")] Waterga_78,
        [Magic("Waterza")] Waterza_79,
        [Magic("Aerora")] Aerora_7A,
        [Magic("Aeroga")] Aeroga_7B,
        [Magic("Aeroza")] Aeroza_7C,
        [Magic("Curaza")] Curaza_7D,
		DarkFiraga,
		Empty_7F,
		DoubleArrowguns,
		HyperHammer,
		TwinYoYos,
		MagicLauncher,
		DrillPunch,
		BlizzardBlades,
		NanoArms,
		UltimateForm,
		MirageStaff,
		Countershield,
		AgileClaws,
		RageForm,
		Highwind,
		StormFlag,
		HunnyBlasters,
		HunnyLauncher,
		BlizzardClaws,
		FryingPan,
		BoomHammer,
		ClockDrill,
		SecondForm,
		SecondFormS,
		SecondFormM,
		SecondFormP,
		SecondFormD,
		Spellweaver,
		Empty_9A,
		Finish_9C,
		Finish_9D,
		Finish_9E,
		Finish_9F,
		Finish_A0,
		Finish_A1,
		Finish_A2,
		Finish_A3,
		Finish_A4,
		Finish_A5,
		Finish_A6,
		Finish_A7,
		Finish_A8,
		Finish_A9,
		DoubleDuel,
        [Magic("Thunder")] Thunder_AA,
		StunImpact,
		SonicBlade,
		[Info("Infinite jump")] Jump = 0xc6,
		ArsArcanum = 0xad,
		AncientLight = 0xae,
		Rave,
		Blast,
		Bash,
		Finish_B2,
		Riskcharge,
		UnionX,
		USERNAME_1,
		USERNAME_2,
		USERNAME_3,
		USERNAME_4,
		USERNAME_5,
		MountainCoaster,
		PirateShip,
		MadTeaCups,
		BlasterBlaze,
		MagicCarrousel,
		SplashRun,
		Finish_C0,
		TrinityGuard,
		[Info("Infinite jump")]TrinitySled,
		GoofyBombardier,
		Empty_C4,
		Empty_C5,
		[Info("Infinite jump")]Empty_C6,
		ScreamStrike,
		NeverFear,
		[Info("Infinite jump")]Empty_C9,
		HeroicSwing,
		MightyAvalance,
		RocketRuckus,
		TangledTwist,
		TreeWhip,
		DonaldMeteor,
		FlareForce,
		InterceptorWing,
		SubzeroImpact,
		LastRay,
		Trinity,
		Sora,
		Finish_D6,
		Empty_D7,
		KingOfHearts,
		Ragnarok,
		DrainShock,
		AtomicDeluge,
		MeteorShower,
		DivingBarrage,
		ClusterCannonade,
		GhostHorde,
		DrillDive,
		ShimmeringDrops,
		SpectralRays,
		Snakebite,
		WarpTrick,
		DiamondDust,
		FrozenCrescents,
		BladeStorm,
		FlagRampage,
		CubicStream,
		ZoneConnector,
		HunnyBurst,
		HunnyDrizzle,
		SweetSurprise,
		SteamSpiral,
		FruitCrusher,
		PhantomRush,
		NoiseFlux,
		BladesOfTheRound,
		UnionRagnarok,
		InfinityCircle,
		KingOfHearts_F5,
		Ragnarok_F6,
		KingOfHearts_F7,
		Ragnarok_F8,
		KingOfHearts_F9,
		Ragnarok_FA,
		FocusSyphon,
		Airstep,
		PrismRain
	}
}
