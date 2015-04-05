#PENDU

##Spécifications techniques

## Environnement techniques

Langage de programmation : C#.
Gestionnaire de versions : Git.
EDI : Microsoft Visual Studio.
Outil pour les tests unitaires : intégré à Visual Studio.
Outil pour l'injection de dépendance : plugin Autofac.

## Conventions

## Conventions de nommage

Les champs non-statique commencent par un underscore et suivent le CamelCase (ex: _monChamp).
Les champs statiques sont écrites en majuscule et un underscore sépare les différents mots (ex: MON_CHAMP_STATIQUE).
Les variables locales suivent le CamelCase (ex: maVariableLocale).
Les méthodes suivent le PascalCase, comme les propriétés (ex: MaMéthode).
Le code et les commentaires sont en anglais.

## Conventions de disposition

Une seule instruction par ligne.
Des parenthèses pour rendre apparentes les clauses d'une expression (ex: (val1 && val2) || (val3 && val4) )
Des accolades pour chaque expression conditionnelle.
Une accolade est seule sur toute une ligne.
Ex :
if (x)
{
	...
}

## Conventions de commentaires

Chaque méthode et/ou champ doit être commenté(e)s.
Les commentaires suivent le modèle conseillé par Microsoft.
Les balises utilisées seront summary, param et returns.

## Conventions d'organisations des tests unitaires

Un fichier de tests par classe.
Chaque développeur doit écrire les tests unitaires testant son code et les exécuter avant de faire un push (si tous les tests passent). 
Chaque développeur doit exécuter tous les tests existants avant de faire un push (si tous les tests passent).

## Composants

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