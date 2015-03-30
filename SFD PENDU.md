#PENDU

##SFD

Spécifications fonctionnelles et techniques du Pendu.

But : Il s'agit de retrouver un mot choisi aléatoirement par l'ordinateur. Le joueur peut faire un nombre fini de propositions.

##Le Dictionnaire

Le dictionnaire contient tous les mots du jeu. Un mot est choisit aléatoirement au début de la partie par le programme.
Le dictionnaire est stocké sous forme de fichier délimité, ce fichier est chargé au début du jeu.

**Le fichier de dictionnaire**
Le fichier se compose d'un mot par ligne terminée par un ';'

##Le Plateau

L'affichage du pendu (image et mot à trouver masqué) se fait dans la console.

##L'image

Elle est générée par un fichier plat comprenant tous les états de l'image. Apparemment 8 états.
Elle est affichée état par état.

##Le joueur

Le joueur a un identifiant(automatique). 

##Les mots

Ils sont d'une longueur comprise entre 3 et 10 lettres.

##La partie

La partie doit pouvoir être gagnée ou perdue ou abandonnée. À la fin d'une partie on propose d'en recommencer une. 

