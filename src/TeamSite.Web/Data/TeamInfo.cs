using TeamSite.Web.Models;

namespace TeamSite.Web.Data;

/// <summary>
/// Everything your team's site says. To change the site, edit this file.
/// Images go in wwwroot/images/.
/// </summary>
public static class TeamInfo
{
    public static readonly Team Team = new()
    {
        Name = "Deviation From the Norm",
        ShortName = "Deviation",
        Program = "FTC",
        Number = 6093,
        Founded = "2012",
        Tagline = "Gracious Professionalism, awards and robot performance.",
        Logo = "/images/deviation-logo.png",
        AccentColor = "#38bdf8",
        Email = "deviationftm6093@gmail.com",
        Socials =
        [
            new("Instagram", "https://www.instagram.com/deviationfromthenorm"),
            new("X", "https://www.twitter.com/DeviationFTM"),
        ],
        Highlights =
        [
            "Founded 2012, revived 2022",
            "15 committed members",
            "Programming help for other FTC teams",
        ],
        Story =
        [
            "Deviation From the Norm formed in 2012 and went dormant before COVID-19 in 2019. Students revived the team in 2022. We strive to embody FIRST's Gracious Professionalism while competing for awards and pushing robot performance. This year 15 members are committed to reaching our goals.",
        ],
        Outreach =
        [
            new("Gigi's Playhouse",
                "We partnered with Gigi's Playhouse to give teens with Down syndrome a mini FTC season. Over six weeks, participants built, programmed and showcased their own robots in an inclusive camp."),
            new("Device Mount",
                "An AEA physical therapist at PV asked for help with a preschool student whose communication device couldn't attach to her stander, so we designed and built a mount for her."),
            new("Programming Assistance",
                "We fixed a broken Gradle build for team"),
            new("Society of Women Engineers",
                "With 25 female engineers from John Deere, we helped host a SWE event in the PVHS library so young women could learn about careers in engineering and STEM. We made the flyers and sent the invitations."),
            new("Girl Scouts",
                "At a Girl Scouts camp at Liberty Campground, our members taught young girls about robotics and STEM, helped them code robots and built catapults."),
            new("FLL Mentoring",
                "Team members go to Pleasant Valley Jr. High to help the FIRST LEGO League team Aquatic Alphas with mechanical design, prototyping and programming."),
            new("Davenport Public Works",
                "We collected 20 bags of trash to keep it out of the Mississippi River, and we're helping design and install rain gardens around Davenport."),
            new("Summer Camp",
                "Students in grades 6–8 built and designed robots to compete with their peers, coached by robotics members in programming, 3D modeling and building."),
            new("Mississippi Valley Fair",
                "We set up a stand at the fair, promoted robotics and FIRST, and let visitors drive our robots."),
            new("John Deere MTIC",
                "John Deere employees gave us a tour and helped us explore career paths, and we connected with FIRST members and potential mentors."),
            new("Flags",
                "We set up and take down flags around neighborhoods for patriotic holidays."),
        ],
    };

    // The menu at the top of every page. Add a line when you add a page.
    public static readonly List<(string Label, string Href)> Nav =
    [
        ("Home", "/"),
    ];

    public const string PvSite = "https://www.firstpvrobotics.com";
}
