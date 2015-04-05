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


# Fonctions

* Fonction choisir mot :

Choisit un mot au hasard dans le dictionnaire.

* Fonction proposer lettre :

Le joueur propose une lettre

Erreurs : chiffre ou caractère spécial proposé 

* Fonction proposer mot :

 Le joueur propose un mot. Appel à la fonction proposer lettre récursivement.

* Fonction abandonner :

Le joueur abandonne, la partie doit être relancée.

* Fonction afficher les règles :

Les règles sont affichées, le joueur doit pouvoir quitter cet affichage.

* Fonction afficher potence :

Affiche la potence en fonction du score du joueur.

* Fonction vérifier lettre proposée :

Vérifier la lettre et fait appel à l’affichage de la potence dans le cas où la lettre est fausse.

* Fonction afficher lettre à trouver :

Affiche les lettre déjà trouvées par le joueur.


