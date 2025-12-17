# INFO4900 – Challenge de rendu et de dynamique physique

## 1. Présentation du projet

Ce projet a été réalisé dans le cadre du cours **INFO4900 – Sujets avancés en informatique (Automne 2025)**. Il consiste à concevoir une scène 3D mettant en valeur un rendu visuel de qualité, une dynamique physique réaliste et une déformation crédible d’objet, conformément au cahier des charges fourni.

La scène représente une **table en bois** supportant un **verre transparent** et un **objet métallique**, tandis qu’une **balle souple** tombe, se déforme à l’impact, reprend sa forme et interagit avec les autres éléments.

---

## 2. Objectifs pédagogiques

* Mettre en œuvre un moteur de rendu 3D temps réel
* Simuler des phénomènes physiques réalistes (gravité, collisions, rebonds)
* Implémenter un modèle simple de déformation d’objet
* Structurer un projet Unity propre et documenté
* Produire des livrables reproductibles et conformes aux règles d’éthique

---

## 3. Technologies utilisées

* **Moteur** : Unity 3D Core
* **Langage** : C#
* **Version Unity recommandée** : 2021 LTS à 2023 LTS
* **Plateforme** : Windows
* **Contrôle de version** : Git / GitHub

---

## 4. Description de la scène

La scène contient les éléments suivants :

* Une table en bois composée d’un plateau et de quatre pieds
* Un verre transparent posé sur la table
* Un petit objet métallique (clé/cuillère simplifiée)
* Une balle souple soumise à la gravité, aux collisions et à une déformation temporaire
* Un éclairage directionnel et un environnement simple

Le comportement physique repose sur les composants **Rigidbody**, **Collider** et **Physic Materials** fournis par Unity.

---

## 5. Architecture du projet

```
Assets/
│
├── Scenes/            # Scène principale Unity
├── Scripts/           # Scripts C# (déformation, génération de table)
├── Materials/         # Matériaux (bois, verre, métal)
├── Textures/          # Textures utilisées (bois, etc.)
├── Prefabs/           # Préfab de la table
└── README.md
```

Scripts principaux :

* `TableGenerator.cs` : génération automatique du plateau et des pieds de la table
* `SoftBallDeformation.cs` : gestion de la déformation de la balle lors des collisions

---

## 6. Instructions d’installation

1. Installer **Unity Hub**
2. Installer une version compatible de Unity (2021–2023 LTS)
3. Cloner le dépôt GitHub :

   ```bash
   git clone <URL_DU_DEPOT>
   ```
4. Ouvrir Unity Hub → *Open Project* → sélectionner le dossier du projet

---

## 7. Instructions d’exécution

1. Ouvrir la scène principale située dans `Assets/Scenes`
2. Cliquer sur **Play** ▶️ dans l’éditeur Unity
3. Observer la chute de la balle, sa déformation à l’impact et ses interactions avec la table et l’objet métallique

---

## 8. Choix techniques

* **Physique** : moteur physique intégré de Unity (Rigidbody + Collider)
* **Déformation** : modification dynamique de l’échelle de la balle lors de l’impact, suivie d’un retour progressif à la forme initiale
* **Collisions** : Box Collider pour la table, Sphere Collider pour la balle, Mesh/Box Collider pour les autres objets
* **Rendu** : matériaux Standard, transparence pour le verre, éclairage directionnel

---

## 9. Limites et pistes d’amélioration

* Modèle de déformation simplifié (échelle uniforme)
* Absence de déformation basée sur un maillage dynamique
* Amélioration possible du réalisme via URP/HDRP
* Ajout de sons, d’ombres précalculées et de textures plus détaillées

---

## 10. Assets et licences

* Modèles géométriques simples créés dans Unity
* Textures libres de droits ou générées localement
* Aucun asset propriétaire non crédité

---

## 11. Éthique académique

* Aucun plagiat de code ou d’assets
* Tous les scripts ont été écrits spécifiquement pour ce projet
* L’utilisation d’outils d’assistance a été déclarée conformément aux règles du cours

---

## 12. Auteurs

Projet réalisé par :

Kadijatou Condé
Ousmane Diallo
Emmanuelle Assié Ekou
Aicha Woury Ba

Cours : INFO4900 – Sujets avancés en informatique
Université De Moncton
Session : Automne 2025

