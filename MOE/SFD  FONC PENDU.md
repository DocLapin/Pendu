#PENDU

##SFD

Spécifications fonctionnelles du Pendu.

But : Il s'agit de retrouver un mot choisi aléatoirement par l'ordinateur. 
Le joueur peut faire un nombre fini de propositions.
Après 8 propositions érronées, le joueur a perdu la partie.

# Fonctions

* Fonction choisir mot :

Choisit un mot au hasard dans le dictionnaire.
Cette fonction est la première utilisée, elle represente le choix par l'ordinateur d'un mot aléatoire.
Vient ensuite le premier tour du joueur qui doit proposer une lettre.

* Fonction proposer lettre :

Le joueur propose une lettre.
Si la lettre proposée est dans le mot, elle s'affiche à sa bonne position.
Si elle n'est pas dans le mot, le pendu passe à son état suivant.

Erreurs : chiffre ou caractère spécial proposé 

* Fonction proposer mot :

En plus de pouvoir proposer une lettre.
Le joueur peut proposer un mot à la place. 
Si c'est le bon mot, le joueur gagne la partie.
Sinon le pendu passe à son état suivant.

* Fonction abandonner :

Le joueur peut abandonner, la partie doit être relancée depuis le choix du mot.

* Fonction afficher les règles :

À tout moment, le joueur peut afficher les règles du jeu.
Les règles sont affichées, le joueur doit pouvoir quitter cet affichage.

* Fonction afficher potence :

Cette fonction permet de passer le pendu à l'état suivant et donc de l'afficher.
Affiche la potence en fonction du score du joueur.

* Fonction vérifier lettre proposée :

Cette fonction permet d'évaluer la lettre proposée par le joueur.
Vérifier la lettre et fait appel à l’affichage de la potence dans le cas où la lettre est fausse.

* Fonction afficher lettre à trouver :

Cette fonction 
Affiche les lettre déjà trouvées par le joueur.


