using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Enums
{
    public enum Genre
    {
        [Display(Name = "Alternative Metal")]
        AlternativeMetal,
		[Display(Name = "Alternative Rock")] 
        AlternativeRock,
        Ambient,
        [Display(Name = "Black Metal")]
        BlackMetal,
        Blues,
        Classical,
        Country,
        [Display(Name = "Death Metal")]
        DeathMetal,
        [Display(Name = "Doom Metal")]
        DoomMetal,
        [Display(Name = "Drum And Bass")]
        DrumAndBass,
        Dubstep,
        EDM,
        Folk,
        Grunge,
        [Display(Name = "Heavy Metal")]
        HeavyMetal,
        [Display(Name = "Hip-Hop")]
        HipHop,
        House,
        [Display(Name = "Indie Rock")]
        IndieRock,
        Jazz,
        [Display(Name = "K-Pop")]
        KPop,
        Manele,
        [Display(Name = "Metal Core")]
        MetalCore,
        [Display(Name = "Nu Metal")]
        NuMetal,
		Pop,
        [Display(Name = "Post Rock")]
        PostRock,
        [Display(Name = "Progressive Metal")]
        ProgressiveMetal,
        [Display(Name = "Progressive Rock")]
        ProgressiveRock,
        [Display(Name = "Punk Rock")]
        PunkRock,
        Rap,
        Reggae,
        RnB,
        Rock,
        Soul,
        Synthwave,
        Techno,
        Trance,
        Trap,
		}
}
