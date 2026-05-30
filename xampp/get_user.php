<?php
$mysqli = new mysqli("localhost","root","","flappy");
if($mysqli->connect_error)
{
    echo "error";   
}
else
{
    $username = $_POST["username"];
    $score = $_POST["score"];
    $sql="SELECT * FROM users WHERE username=?;";
    $query=$mysqli->prepare($sql);
    $query->bind_param("s",$username);
    $query->execute();
    $result=$query->get_result();
    if($result->num_rows>0)
    {
        $sql="UPDATE users SET score=? WHERE username=?;";
        $query=$mysqli->prepare($sql);
        $query->bind_param("is",$score,$username);
        if($query->execute())
        {
            echo "score actualizado";
        }
        else
        {
            echo "error al actualizar score";
        }
    }
    else
    {

        $sql="INSERT INTO users(user_id,username,score) VALUES (NULL,?,?);";
        $query=$mysqli->prepare($sql);
        $query->bind_param("si",$username,$score);
        if($query->execute())
        {
            echo "se insertó el nuevo usuario con su score";
        }
        else
        {
            echo "error al actualizar score";
        }
    }

    $mysqli->close();
}



?>