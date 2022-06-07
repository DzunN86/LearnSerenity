using Serenity.Navigation;
using MyPages = PelanggaranSantri.MasterData.Pages;
using MoviePages = PelanggaranSantri.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "MasterData", icon: "fa-university")]
[assembly: NavigationLink(2300, "MasterData/Siswa", typeof(MyPages.SiswaController), icon: "fa-tags")]
[assembly: NavigationLink(2100, "MasterData/Pelanggaran", typeof(MyPages.PelanggaranController), icon: "fa-list")]

[assembly: NavigationMenu(3000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(3100, "Movie Database/Movie", typeof(MoviePages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(3300, "Movie Database/Genre", typeof(MoviePages.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(3400, "Movie Database/Person", typeof(MoviePages.PersonController), icon: "fa-users")]


