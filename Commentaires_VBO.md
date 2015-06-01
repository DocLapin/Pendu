# TL; DR

17 / 20

Très bon respect des consignes sur la partie rédactionnelle, utilisation efficace de Git et Markdown. Chaque document est concis, parfois un peu trop, mais répond à son objectif. J'espère que cela se traduit dans le code. Beaucoup d'initiatives dans les documents, il reste maintenant à en avoir sur les méthodologies ;)

# MOA TicTacToe

## Cahier des charges (CdC)

* L'introduction est plus une définition du vocabulaire utilisé qu'une véritable introduction, ça arrive un peu comme un cheveux sur la soupe, et quand bien même, il y a des descriptions des règles du jeu (e.g. la mort subite) dans la définition d'un "symbole".
* Le format de fichier c'est JSON (JavaScript Object Notation), pas de `y` !
* Il n'était pas forcément nécessaire de préciser ce qui devait être sauvegardé, il fallait dire que vous vouliez que la partie reprenne à l'exact moment où elle avait été quittée.
* Ça manque un peu de forme et de structure mais l'essentiel y est.

## Cahier de recettes (CdR)

* Les scénarios sont décrits dans un ordre chrono(&)logique : la première vérification consiste effectivement à vérifier que l'application démarre avant de s'attaquer vers la fin aux cas limites, c'est une excellente approche d'aller du général au particulier.
* Tous les cas ne sont pas couverts (e.g. attribution automatique du signe, mort subite avec plusieurs égalités) mais chaque cas est suffisament atomique et reste fonctionnel (pas de technique, excepté pour le format du fichier mais fait partie du CdC)

## Soutenance

* RAS

# MOE Pendu

## Spécifications fonctionnelles

* Très bonne initiative de référencer les documents utilisés. Il ne manque plus qu'un lien direct pour y accéder ce sera parfait ;)
* Excellent d'avoir conscience de son audience.
* La description des fonctions fait un peu trop "catalogue", elle manque de dynamisme ou d'un "workflow" : on ne sait pas dans quel ordre s'agencent ces fonctions.
* Bonne couverture des besoins fonctionnels cela dit.

## Spécifications techniques

* Rappel du contexte technique et des conventions de nommages : très bien ! Ça permet à toute l'équipe de travailler en harmonie au niveau du code et d'éviter les divergences.
* Comme pour les spécifications fonctionnelles, la liste des fonctions ne présente pas comment tous ces composants vont s'agencer. Il manque un diagramme d'état ou un schéma pour situer chaque composant par rapport aux autres.
* Vous êtes le seul groupe à avoir pris le temps de rédiger ce document, un très bon point pour vous d'autant qu'il est plutôt complet.

# Rapport

* Jolie référence à Hollywood ;)
* Bonne initiative sur les tests unitaires à chaque commit mais cela relève de l'organisation de chacun, avez-vous cherché des moyens d'automatiser cela ?
* Bonne idée d'avoir retracer la chronologie du projet, cela présente aussi implicitement votre démarche et votre raisonnement.
* Il manque les difficultés rencontrées (ou alors il n'y en avait aucune et je peux demander des choses plus complexes !) et le bénéfice que vous avez tiré de ces projets (sur le plan humain, technique, organisationnel)
* Un aspect est de coder "propre", parce que d'habitude vous coder "sale" ?!
* Bon compte-rendu dans l'ensemble, on sent qu'il n'a pas été fait à la va-vite même si la conclusion arrive un peu rapidement.