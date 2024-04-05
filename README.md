# TP06
## B. Définir une page de disposition
### 1. En exécutant l’application, quelle est la page par défaut qui se lance ? Si on souhaite la changer, dans quel fichier doit-on faire les modifications nécessaires ?
La page par défaut sera généralement l'index du controleur Home, car dans le fichier RouteConfig.cs les paramètres par défaut spécifiés à l'aide de la propriété "defaults" indiquent quel contrôleur, quelle méthode d'action ou quelle valeur de paramètre id doit être utilisée.

### 3. Quelle est le layout principal de notre application, par défaut ? Décrire l’instruction permettant de charger le contenu d’une page à l’intérieur d’une page de disposition.
Layout principal de notre application par défaut est généralement spécifié dans le fichier _Layout.cshtml et situé dans le répertoire Views/Shared et pour charger le contenu d'une page on utilise @RenderBody()

### 4. Quelles méthodes peut-on adopter pour définir un layout principal de notre application ?
- Au niveau du fichier _ViewStart.cshtml
- Au niveau de la vue fille
- Au niveau d’une méthode d’action
