## Spécifications fonctionnelles du Pendu ##

# Caractéristiques de la solution

La solution est un programme affiché sous console permettant de jouer à jeu du "pendu". Il s'agit pour un joueur de retrouver un mot choisi aléatoirement par l’ordinateur dans un dictionnaire défini préalablement. 

Le joueur peut faire un nombre fini de propositions. Après 8 propositions erronées, le joueur à perdu la partie.

# Acteurs du projet

La direction métier : l’équipe "tictactoe".

# Documentation référencée

SFD FONC PENDU.md : spécifications fonctionnelles détaillées de la solution (document présent).

CDC pendu.pdf : cahier de charges fourni par la direction métier.

SPEC TECH PENDU.md : spécifications techniques de la solution.

TO DO.md : liste des activités à réaliser.

# Population des utilisateurs visée

Les utilisateurs n’ont pas de qualifications particulières à avoir. Les utilisateurs doivent avoir une bonne connaissance de la langue française, et savoir utiliser la console, le clavier et la souris.

# Fonctions

* **Choisir mot :**

Choisit un mot au hasard dans le dictionnaire.
Cette fonction est la première utilisée, elle représente le choix aléatoire d'un mot par l'ordinateur.
Vient ensuite le premier tour du joueur qui doit proposer une lettre.

* **Proposer lettre :**

Le joueur propose une lettre.
Si la lettre proposée est dans le mot, elle s'affiche à sa bonne position.
Si elle n'est pas dans le mot, le pendu passe à son état suivant.

Erreur : chiffre ou caractère spécial non autorisé proposé 

* **Proposer mot :**

En plus de pouvoir proposer une lettre.
Le joueur peut proposer un mot à la place. 
Si c'est le bon mot, le joueur gagne la partie.
Sinon le pendu passe à son état suivant.

* **Abandonner :**

Le joueur peut abandonner, la partie doit ensuite être relancée depuis l'écran "choix du mot".

* **Afficher les règles :**

À tout moment, le joueur peut afficher les règles du jeu.
Les règles sont affichées, le joueur doit pouvoir quitter cet affichage.

* **Afficher potence :**

Cette fonction permet de passer le pendu à l'état suivant et donc de l'afficher.
Affiche la potence en fonction du score du joueur.

* **Vérifier lettre proposée :**

Cette fonction permet d'évaluer la lettre proposée par le joueur.
Vérifier la lettre et fait appel à l’affichage de la potence dans le cas où la lettre est fausse.

* **Afficher lettres trouvées :**

Cette fonction affiche les lettres déjà trouvées par le joueur.  

* **Afficher nombre de lettres restantes :**

Cette fonction affiche le nombre de  lettres restantes à trouvées par le joueur.  

