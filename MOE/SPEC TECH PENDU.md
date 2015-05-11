# Spécifications techniques

## Environnement techniques

Langage de programmation : C#.  
Gestionnaire de versions : Git.  
EDI : Microsoft Visual Studio.  
Outil pour les tests unitaires : intégré à Visual Studio.  
Outil pour l'injection de dépendance : plugin Autofac.  

## Conventions

* Conventions de nommage

Les champs non-statique commencent par un underscore et suivent le CamelCase (ex: _monChamp).
Les champs statiques sont écrites en majuscule et un underscore sépare les différents mots (ex: MON_CHAMP_STATIQUE).
Les variables locales suivent le CamelCase (ex: maVariableLocale).
Les méthodes suivent le PascalCase, comme les propriétés (ex: MaMéthode).
Le code et les commentaires sont en anglais.
Les interfaces commencent par la lettre 'I'.

* Conventions de disposition

Une seule instruction par ligne.
Des parenthèses pour rendre apparentes les clauses d'une expression (ex: (val1 && val2) || (val3 && val4) )
Des accolades pour chaque expression conditionnelle.
Une accolade est seule sur toute une ligne.
Ex :
if (x)
{
	...
}

* Conventions de commentaires

Chaque méthode et/ou champ doit être commenté(e)s.
Les commentaires suivent le modèle conseillé par Microsoft.
Les balises utilisées seront summary, param et returns.

* Conventions d'organisations des tests unitaires

Un fichier de tests par classe à tester.
Chaque développeur doit écrire les tests unitaires testant son code et les exécuter avant de faire un push (si tous les tests passent). 
Chaque développeur doit exécuter tous les tests existants avant de faire un push (si tous les tests passent).

## Composants

### Dictionnaire (Dictionnary)

Le dictionnaire contient tous les mots du jeu. Un mot est choisit aléatoirement au début de la partie par le programme.
Le dictionnaire est stocké sous forme de fichier délimité, ce fichier est chargé au début du jeu.

#### Signature des méthodes

public Dictionnary(List<Word> ...)
public void Load()  
public Word SelectAWord()  
public Word SelectAWord(int minimalSize, int maximalSize)  

### Stockage des mots (IWordStorage)

Les mots seront stockées dans un fichier avec un mot par ligne terminée par un ';'
La classe représentant ce fichier sera nommée WordFile.
Néanmoins nous prévoyons le changement de type de stockage donc nous utiliserons une interface (IWordStorage) qui sera implémentée par WordFile.

#### Signature des méthodes

public void Load()  
Exclusif à la classe WordFile: public WordFile(String filePath)

### Mot (Word)

Représente les mots d'une longueur comprise entre 3 et 10 lettres.

#### Signature des méthodes

public Word(String)  
public int GetSize()  
public int GetNbLetterFound()  
public boolean IsLetterCorrect(Letter ...)  

### Jeu (Game)

Représente le jeu.

#### Signature des méthodes

public Game(Joueur ..., Dictionnary ..., IInput ..., IOutput ..., Rules ..., ICharacter ...)  
public void Play()  
public void Reset()  
public void Quit()  
public boolean IsFinished()
public void ShowRules()  
public void ShowCharacter()  
public void ShowWord()  
public string Ask()  

### Règles (Rules)

Représente toutes les données concernant les règles du jeu (longueur minimale et maximales des mots ...)

#### Signature des méthodes
 
public void ShowRules(Rules ...)  
+ attributs pour représenter les règles.

### Sortie (IOutput)

L'affichage pourra se faire dans la console mais nous prévoyons la nécessité d'avoir une autre sortie.
La classe OutputConsole implémentera donc l'interface IOutput

#### Signature des méthodes

public void ShowRules(Rules ...)  
public void ShowCharacter(Character ...)  
public void ShowWord(Word ...)  

### Entrée (IInput)

Les saisies pourront se faire dans la console mais nous prévoyons la nécessité d'avoir une autre entrée.
La classe InputConsole implémentera donc l'interface IInput

#### Signature des méthodes

public String Saisie()

### Personnage (ICharacter)

Image générée par un fichier plat (classe Character) comprenant tous les états de l'image. Il y a 8 états.
Elle est affichée état par état.

#### Signature des méthodes

public void SetFichier(String fileName)  
public String[] GetEtat(int num)  
public Boolean IsFinal()  

## Fichiers spécifiques

* Fichier de configuration

Stockage des données utilisées dans le programme dans un fichier de configuration pour éviter de devoir faire une nouvelle compilation puis un nouveau déploiement.

* Fichier de dessin

Pour l'affichage du pendu, l'application utilise un fichier spécifique qui contient tous les états du pendu à affiche.  
Les états sont séparés par leurs numéros. Seul les lignes entre chaques numéros d'états sont renvoyés.  
Ex :  
0 //Début état 0
 
 
 
 
 
 
_____
1 //Fin état 0, Début état 1  
 _______
 |/ 
 |  
 | 
 | 
 | 
_|___
2 //Fin état 1, Début état 2  
 _______
 |/ |
 |  
 | 
 | 
 | 
_|___
3 //Fin état 2, Début état 3  

L'état "0" est celui entre le numéro 0 et le 1.  
Le fichier est au format ".txt".
