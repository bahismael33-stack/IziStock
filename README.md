# IziStock

IziStock est un logiciel Windows (7+) de gestion de stock pour petits commerces, boutiques et PME au Mali. Basé sur le framework .NET 4.7.1 (WPF), avec une base de données SQLite locale — aucune connexion internet requise pour fonctionner.

Adapté du projet open-source [SimpleInventory](https://github.com/codezips/simple-inventroy-management) par MaliTechSolution, avec devise par défaut en **Franc CFA (FCFA)**.

IziStock peut être modifié avec Visual Studio 2017+.

## Fonctionnalités

* Plusieurs utilisateurs, chacun avec des permissions différentes selon les fonctionnalités
* Gestion du stock courant (quantités en temps réel)
* Classement des articles par catégories (boissons, fournitures, etc.) — utilisées pour les sous-totaux dans les rapports
* Scan des articles via lecteur de code-barres pour un enregistrement rapide des ventes
* Lors d'un achat : saisie de la quantité et du montant payé, calcul automatique de la monnaie à rendre — y compris en devises différentes
  * Note : la modification des devises se fait directement via un éditeur SQLite (pas encore d'interface dédiée)
* Génération de PDF de codes-barres à imprimer
* Rapports journaliers/hebdomadaires : revenus générés, articles vendus, bénéfices réalisés
* Rapports d'inventaire : niveau de stock à une date donnée
* Historique détaillé des ventes et ajustements de quantité, à la seconde près

## Identifiants par défaut

Nom d'utilisateur : `admin` — Mot de passe : `changeme`. **À changer avant toute utilisation réelle.**

## Devise par défaut

Franc CFA (FCFA / XOF). Le Dollar US (USD) reste disponible en devise secondaire pour les achats fournisseurs internationaux.

## Pistes d'évolution

* Interface dédiée pour ajouter/modifier les devises
* Champ de recherche sur l'écran d'inventaire
* Rapports plus poussés
* Mode "point de vente" : un achat avec plusieurs articles, activable/désactivable
* Réglages pour format de papier, format de date, etc.

### Améliorations techniques

* Utiliser LINQ pour nettoyer les appels SQLite manuels
* Interface générique pour la création d'objets au lieu d'une interface par type

## Licence

MIT License — basé sur SimpleInventory (MIT), adapté par MaliTechSolution pour le marché malien.
