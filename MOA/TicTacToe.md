#Tic-Tac-Toe

##Introduction
**Tic-Tac-Toe** : Jeu à deux joueurs humains, en tour par tour, et dont le but est d’aligner trois symboles sur une grille de 3x3. 

**Manche** : Le jeu est constitué de cinq manches, une manche est finie quand un joueur a aligné 3 symboles ou que le jeu est bloqué. 

**Symbole** : Les symboles sont « X » et « O ». Au début de la partie, le joueur 1 choisit son symbole, et le joueur 2 obtient le deuxième symbole. 
En cas d’égalité au bout des 5 manches, des manches sont ajoutées en « mort subite ». La première manche gagnée permet de gagner la partie.

##Spécifications fonctionnelles
Le score de la partie doit être indiqué (nombre de manches gagnés par joueurs).

À la fin de la partie, on peut recommencer une partie.
L’état de la partie doit être sauvegardé au fur et à mesure dans un fichier. 
Le format du fichier devra être le format JYSON.
Cette sauvegarde comprend : 
    Le nom des joueurs
    Le score de chacun des joueurs
    L'état de la grille (placement des symboles pour éventuellement reprendre la partie).



##Déroulement d'une partie
**Début** : Le premier joueur inscrit son nom, puis il choisit soit le symbole "X" ou "O", sans choix de sa part le symbole "X" lui est attribué par défaut. Le deuxième joueur inscrit son nom, le symbole attribué est celui restant disponible après le choix du joueur 1, sans choix du joueur 1 le symbole "O" lui est attribué par défaut.

**Partie** : Le nom du joueur qui a la main doit être affiché. Le joueur positionne son symbole sur la grille dans un emplacement disponible, une erreur s'affiche si il essaye d'ajouter son symbole sur un emplacement déjà pris, puis le tour passe au second joueur.

**Fin de Manche** : Le nom du joueur vainqueur est affiché ansi que le score actuel de la partie.

**Fin de Partie** : Le nom du joueur vainqueur est affiché ansi que le score final de la partie.
