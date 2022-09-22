# TopDownGameTutorial

Build version v0.1 22/09/2022
File .exe dapat ditemukan dalam game.zip

Pendahuluan
Sesuai dengan target yang sudah disepakati pada kelas PRPL tanggal 13/09/2022, kami perlu mengimplementasikan 3 hal berikut:
-Player dapat bergerak leluasa
-Player dapat menyerang
-Terdapat karakter lawan sebagai target serangan

Progress sampai dengan tanggal 13/09/2022:
Sampai dengan tanggal ini kami sudah:
-mengumpulkan resource untuk dimasukkan ke dalam game berupa,
 -tilemaps, yaitu sekumpulan image berukuran 16x16 pixel yang bisa dimasukkan ke dalam game untuk membentuk map untuk game
 -sprites, yaitu sekumpulan image yang bisa dimanipulasi untuk mensimulasikan pergerakan karakter, baik player maupun musuh, baik bergerak, menyerang, maupun idle
-selain mengumplkan resource kami juga sudah menaruh resource ke dalam game untuk menunjukkan bagaimana tampilan game kami ke depannya

Progress sampai dengan tanggal 20/09/2022
Sampai dengan tanggal ini kami sudah:
-membuat beberapa animasi berupa pergerakan karakter, pergerakan slime, serangan karakter, karakter terkena damage, slime terkena damage, karakter mati, slime mati, karakter diam, slime diam, dan air mancur
 -dari animasi tersebut kami sudah mengimplementasikan pergerakan karakter, karakter diam, slime diam, dan slime mati, yang selanjutnya akan dijelaskan dalam document
-kami mengimplementasikan collision untuk player, senjata player, objek, dan slime
 -collision pada senjata player dan musuh digunakan untuk mengimplementasikan serangan player, yang mana akan dijelaskan dalam document
 -collision pada player dan objek digunakan untuk mencegah player menembus dinding, yang mana akan dijelaskan dalam document
-kami menyebarkan slime di sepanjang map dalam keadaan diam saja
-dengan menggunakan teknik yang sama kami memasukkan air mancur sebagai objek di dalam game agar ada animasi seakan air mancur mengalir selama permainan

Berdasarkan target yang sudah ditentukan sebelumnya, build ini sudah mencapai target 100%
Namun, dalam realitanya kami baru mencapai 1-3% dari keseluruhan ide game kami.

Kami belum mengimplementasikan UI apa pun, user bahkan belum bisa keluar dari game kecuali dengan menekan tombol windows, alt+tab, atau menutup paksa game dengan task manager.
