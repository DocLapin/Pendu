#Tic-Tac-Toe

##Introduction
**Tic-Tac-Toe** : Jeu à deux joueurs humains, en tour par tour, un joueur  affiche un symbole par tour, et dont le but est d’aligner trois symboles sur une grille de 3x3. 

**Manche** : Le jeu est constitué de cinq manches, une manche est finie quand un joueur a aligné 3 symboles ou que le jeu est bloqué. 

**Symbole** : Les symboles sont « X » et « O ». Au début de la partie, le joueur 1 choisit son symbole, et le joueur 2 obtient le deuxième symbole. 
En cas d’égalité au bout des 5 manches, des manches sont ajoutées en « mort subite ». La première manche gagnée permet de gagner la partie.

##Spécifications fonctionnelles
Le score de la partie doit être indiqué (nombre de manches gagnés par joueurs).
A la fin de la partie, on peut recommencer une partie.
L’état de la partie doit être stocké au fur et à mesure.

##Spécifications techniques
La grille est affichée dans la console système.

Pour placer son symbole, un joueur utilisera le pavé numérique représentant la grille 3x3 : 

* 1 -> case en bas à gauche
* 2 -> case en bas au centre
* 3 -> case en bas à droite
* 4 -> case au centre à gauche
* 5 -> case du milieu
* 6 -> case au centre à droite
* 7 -> case en haut à gauche
* 8 -> case en haut au centre
* 9 -> case en haut à droite
