SELECT product_name, category_name
FROM products
LEFT JOIN categories ON products.category_id = categories.category_id