namespace BRASAS_GOURMET.Models
{
    public static class MenuData
    {
        private static ProductoMenu P(string cat, string nombre, decimal precio) =>
            new ProductoMenu { Categoria = cat, Nombre = nombre, Precio = precio };

        public static readonly List<ProductoMenu> Productos = new()
        {
            // SALCHIPAPAS
            P("Salchipapas","Mini",8000), P("Salchipapas","Salchi Kis",12000), P("Salchipapas","Sencilla",16000),
            P("Salchipapas","Ranchera",20000), P("Salchipapas","Americana",13000), P("Salchipapas","Choripapa",18000),
            P("Salchipapas","Suiza",22000), P("Salchipapas","Choricarne",24000), P("Salchipapas","Especial",24000),
            P("Salchipapas","Salchiloka",27000), P("Salchipapas","Recomendada",30000), P("Salchipapas","Familiar",50000),

            // HAMBURGUESAS
            P("Hamburguesas","Sencilla",17000), P("Hamburguesas","Sencilla Pollo",17000), P("Hamburguesas","Ranchera",20000),
            P("Hamburguesas","Doble Carne",24000), P("Hamburguesas","Especial",24000), P("Hamburguesas","Gourmet Pollo",24000),
            P("Hamburguesas","Gourmet",26000), P("Hamburguesas","Criolla",26000), P("Hamburguesas","Super",30000),

            // PERROS CALIENTES
            P("Perros Calientes","Sencillo",9000), P("Perros Calientes","Americano Sencillo",10000), P("Perros Calientes","Ranchero",14000),
            P("Perros Calientes","Suizo",16000), P("Perros Calientes","Choriperro",16000), P("Perros Calientes","Costeño",16000),
            P("Perros Calientes","Americano Especial",23000), P("Perros Calientes","Especial",24000), P("Perros Calientes","Super Perro",27000),

            // DESGRANADOS
            P("Desgranados","Chorizo",22000), P("Desgranados","Carne",22000), P("Desgranados","Ranchero",22000),
            P("Desgranados","Pollo Jamón",22000), P("Desgranados","Suizo",22000), P("Desgranados","Especial",25000),

            // WRAPS
            P("Wraps","Carne",20000), P("Wraps","Lomito",20000), P("Wraps","Atún",20000), P("Wraps","Brasas",24000),

            // CREPS
            P("Creps","Pollo",20000), P("Creps","Mixto",20000), P("Creps","Gourmet",24000), P("Creps","Especial",24000),

            // PICADAS
            P("Picadas","Personal (2 personas)",30000), P("Picadas","Mediana (3 personas)",40000), P("Picadas","Familiar",50000),

            // PANINIS
            P("Paninis","Pollo",22000), P("Paninis","Atún",22000), P("Paninis","De La Casa",24000), P("Paninis","Especial",24000),

            // ASADOS
            P("Asados","Carne",24000), P("Asados","Lomo",24000), P("Asados","Pechuga",24000), P("Asados","Pechuga Gratinada",26000),
            P("Asados","Pincho Mixto",24000), P("Asados","Punta Gorda",28000), P("Asados","Costillas BBQ",28000),
            P("Asados","Parrilla Brasas",30000), P("Asados","Carne Jumbo",38000), P("Asados","Lomo Jumbo",38000),
            P("Asados","Pechuga Jumbo",38000),

            // ENSALADAS
            P("Ensaladas","Pollo",20000), P("Ensaladas","Atún",20000), P("Ensaladas","Cerdo Agridulce",20000),

            // SANDWICH
            P("Sandwich","Sencillo",6000), P("Sandwich","Especial con papas",15000),

            // PATACONES
            P("Patacones","Especial",24000), P("Patacones","Patacón con Queso",13000),

            // PORCIONES
            P("Porciones","Papas",5000), P("Porciones","Papas Gratinadas",8000), P("Porciones","Papas con Queso",8000),
            P("Porciones","Patacones",4000), P("Porciones","Porción de Queso",5000),

            // BEBIDAS (los que tienen precio 0 complétalos con tu precio real)
            P("Bebidas","Cerveza",0), P("Bebidas","Gaseosa Personal",0), P("Bebidas","Jugo Hit",0),
            P("Bebidas","Gaseosa 1.5 Lt",0), P("Bebidas","Gaseosa 3 Lt",0),
            P("Bebidas","Jugo Natural (en agua)",8000), P("Bebidas","Jugo Natural (en leche)",9000),
            P("Bebidas","Milo",10000), P("Bebidas","Limonada Cerezada",10000), P("Bebidas","Limonada Natural",8000),
            P("Bebidas","Limonada de Coco",10000), P("Bebidas","Michelada",10000),
        };

        public static List<string> Categorias =>
            Productos.Select(p => p.Categoria).Distinct().ToList();
    }
}