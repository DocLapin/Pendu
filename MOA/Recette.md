#RECETTE

##Scénario de recette

###Scénario n°1

**But du scénario** : Tester l'execution de l'application  
**Déroulement** : Lancer l'application  
**Résultat attendu** : L'application s'execute ! YO BITCHES !!!!!!  

###Scénario n°2

**But du scénario** :   Le joueur doit être capable d'entrer son nom  
**Déroulement** :  L'utilisateur renseigne son nom lorsque le système lui demande  
**Résultat attendu** :  L'application enregistre le nom saisi par l'utilisateur

 
###Scénario n°3

**But du scénario** : Tester le choix du symbole  
**Déroulement** :  Choisir le symbole du joueur 1 comme "O" et voir si le joueur 2 ne peut pas le prendre.  
**Résultat attendu** : Le symbole du joueur 1 est "O" et "X" est celui du joueur 2.   

##ERREUR ?

Cette Recette est celle du TIcTacToe, elle n'est pas celle du PENDU !!!

###Scénario n°4

**But du scénario** : Tester que le nombre de lettre apparaît et est correct  
**Déroulement** : Le système affiche un mot au hazard du dictionnaire et doit ensuite afficher le nombre de lettre  
**Résultat attendu** : Le nombre de lettre s'affiche bien et est correct au mot choisi dans le dictionnaire  

###Scénario n°5

**But du scénario** : Tester que les lettres déja trouvées sont affichées et qu'elles sont bien à leur bonnes place  
**Déroulement** : Le système doit afficher les lettres déja entrées par l'utilisateur et qui sont présentes dans le mot  
**Résultat attendu** : Les lettres déja trouvées s'affiche bien à l'écran et leur place dans le mot est correcte  

###Scénario n°6

**But du scénario** : Tester que les lettres non découvertes soit afficher comme des astérisques  
**Déroulement** : Lorsque le système demande à l'utilisateur de renseigner une lettre, il doit afficher les lettres manquantes en tant qu'astérisques  
**Résultat attendu** : Les lettres non découvertes s'affichent en tant qu'astériques.  

###Scénario n°7

**But du scénario** : Tester que la lettre entrée est correcte  
**Déroulement** : Le système demande à l'utilisateur de rentrer une lettre puis vérifie que la lettre entrée correspond à une lettre présente dans le mot choisi dans le dictionnaire.  
**Résultat attendu**: Le système affiche la lettre aux endroits correspondants dans le mot.  

###Scénario n°8

**But du scénario** : Tester que la lettre entrée est érronée  
**Déroulement** : Le système demande à l'utilisateur de rentrer une lettre puis vérifie que la lettre entrée correspond à une lettre présente dans le mot choisi dans le dictionnaire ou qu'elle n'a pas déja été saisie.  
**Résultat attendu**: Le système affiche un message précisant que la lettre entrée est soit érronée, soit déja présente le cas échéant.  

###Scénario n°9

**But du scénario** : Tester que le mot entrée est valide  
**Déroulement** : Le système propose à l'utilisateur de rentrer un mot puis compare le mot entré par l'utilisateur (la chaine de caractères entrée) avec celui choisi dans le dictionnaire.  
**Résultat attendu**: Le système affiche un message à l'utilisateur lui indiquant que la partie est finie et qu'il à gagné  

###Scénario n°10

**But du scénario** : Tester que le mot entrée est erroné  
**Déroulement** : Le système demande à l'utilisateur de rentrer un mot puis vérifie que le mot entré correspond à celui présent dans le dictionnaire.  
**Résultat attendu**: Le système affiche un mesage à l'utilisateur précisant que le mot entrée(la chaine de caractères) n'est pas correcte.

##FIN ERREUR ?

###Scénario n°4

**But du scénario** : Tester le positionnement d'un symbole dans une case 
**Déroulement** : Le joueur choisit la case où il veut mettre son symbole
**Résultat attendu** : Le symbole du joueur est bien dans la case

###Scénario n°5

**But du scénario** : Tester le passage de tour au joueur suivant 
**Déroulement** : Le joueur 1 ou 2 joue une fois
**Résultat attendu** : Le tour passe à l'autre joueur

###Scénario n°6

**But du scénario** : Tester la victoire d'un joueur
**Déroulement** : Le joueur 1 ou 2 aligne 3 de ses symboles
**Résultat attendu** : Le joueur 1 ou 2 doit gagner la manche avec ajout au score

###Scénario n°7

**But du scénario** : Tester l'égalité d'une manche
**Déroulement** : La grille est rempli sans qu'aucun des 2 joueurs n'aient pu aligner 3 de ses symboles
**Résultat attendu** : La manche doit se terminer par une égalité

###Scénario n°8

**But du scénario** : Tester le passage à la manche suivante sans fin de partie
**Déroulement** : Terminer une manche sauf la dernière
**Résultat attendu** : La partie doit continuer par une nouvelle manche


###Scénario n°9

**But du scénario** : Tester la fin d'une partie
**Déroulement** : Les joueurs jouent les 5 manches sans égalité
**Résultat attendu** : La partie doit se terminer avec l'affichage du score et du gagnant

###Scénario n°10

**But du scénario** : Tester la non fin d'une partie après au moins une égalité
**Déroulement** : Les joueurs jouent 5 manches avec au moins une manche d'égalité
**Résultat attendu** : La partie ne doit pas se terminer et continuer avec une nouvelle manche