namespace Beecrowd_Exercises.Sql
{
    public class Bee3482
    {
        /*
          En una red social con varios usuarios que comparten información, es común que un usuario 
          siga a otros. Determina qué usuarios se siguen entre sí, por ejemplo Francisco sigue a Laura
          y Laura sigue a Francisco. El resultado debe contener dos columnas con los nombres de los dos 
          usuarios que se suceden. La primera columna debe contener el nombre del usuario con menor
          número de publicaciones y la segunda con mayor cantidad de publicaciones, por ejemplo entre 
          Francisco y Laura, Francisco tiene 23 publicaciones y Laura 55, por lo que Francisco aparece 
          en la primera columna y Laura en la segunda columna. Además, debes ordenar el resultado por la
          identificación del usuario en la primera columna.

-- SOLUTION --
SELECT CASE
WHEN u.posts<u2.posts THEN u.user_name
ELSE u2.user_name
END AS u1_name,
CASE
WHEN u.posts<u2.posts THEN u2.user_name
ELSE u.user_name
END AS u2_name
FROM users AS u
JOIN followers f1
ON u.user_id = f1.user_id_fk
JOIN users as u2
ON u2.user_id = f1.following_user_id_fk
JOIN followers f2
ON f2.user_id_fk = f1.following_user_id_fk AND f2.following_user_id_fk = f1.user_id_fk
WHERE u.user_id<u2.user_id
ORDER BY
    CASE
        WHEN u.posts<u2.posts THEN u.user_id
        ELSE u2.user_id
    END;





        CREATE TABLE users(
user_id INT NOT NULL PRIMARY KEY
,user_name VARCHAR(100) NOT NULL
,posts NUMERIC NOT NULL);

CREATE TABLE followers (
    follower_id INT NOT NULL PRIMARY KEY,
    user_id_fk INT NOT NULL,
    following_user_id_fk INT NOT NULL,
    CONSTRAINT fk_user_id FOREIGN KEY (user_id_fk) REFERENCES users(user_id),
    CONSTRAINT fk_following_user_id FOREIGN KEY (following_user_id_fk) REFERENCES users(user_id)
);

INSERT INTO users(user_id,user_name,posts) VALUES
(1,'Francisco', 23),
(2,'Brenda', 51),
(3,'Helena', 12),
(4,'Miguel', 70),
(5,'Laura', 55),
(6,'Arthur', 2),
(7,'Alice', 3);

INSERT INTO followers(follower_id, user_id_fk, following_user_id_fk) VALUES
(1,1,5),
(2,2,4),
(3,3,7),
(4,3,6),
(5,4,2),
(6,4,5),
(7,5,1),
(8,5,3),
(9,5,4),
(10,5,2),
(11,7,3);

        */
    }
}
