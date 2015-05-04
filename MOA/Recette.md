#RECETTE

##Scénario de recette

###Scénario n°1

**But du scénario** : Tester l'execution de l'application  
**Déroulement** : Lancer l'application  
**Résultat attendu** : L'application s'execute.

###Scénario n°2

**But du scénario** :   Le joueur doit être capable d'entrer son nom  
**Déroulement** :  L'utilisateur renseigne son nom lorsque le système lui demande  
**Résultat attendu** :  L'application enregistre le nom saisi par l'utilisateur

 
###Scénario n°3

**But du scénario** : Tester le choix du symbole  
**Déroulement** :  Choisir le symbole du joueur 1 comme "O" et voir si le joueur 2 ne peut pas le prendre.  
**Résultat attendu** : Le symbole du joueur 1 est "O" et "X" est celui du joueur 2.   

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

###Scénario n°11

**But du scénario** : Tester la sauvegarde d'une partie   
**Déroulement** : L'un des joueurs sauvegarde la partie    
**Résultat attendu** : La partie est sauvegardée au format JISON  

###Scénario n°12

**But du scénario** : Restaurer la sauvegarde d'une partie   
**Déroulement** : L'un des joueurs restaure la sauvegarde de la partie     
**Résultat attendu** : La partie est restaurée du format JISON  