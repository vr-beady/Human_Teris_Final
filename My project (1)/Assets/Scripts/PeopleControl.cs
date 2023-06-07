using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleControl : MonoBehaviour
{
    public Animation2 an;
    public Transform[] people;

    void Update()
    {
        GameObject[] body = an.Body;

        //°©¬Ö~ÀY³»:0~6
          //°©¬Ö
        people[0].position = (body[23].transform.position + body[24].transform.position) / 2;
        //people[0].rotation = Quaternion.Euler(0, 0, 0);
        //people[0].rotation = Quaternion.FromToRotation(people[0].up, people[1].position - (body[23].transform.position + body[24].transform.position) / 2);
        //people[0].rotation = Quaternion.FromToRotation(people[0].forward, Vector3.Cross(people[1].position - body[23].transform.position, people[1].position - body[24].transform.position));
        /*float p0f = Quaternion.FromToRotation(people[0].right, body[23].transform.position - body[24].transform.position).eulerAngles.x;
        people[0].Rotate(p0f, 0, 0);*/
        //people[0].rotation = Quaternion.LookRotation(Vector3.Cross(people[1].position - body[23].transform.position, people[1].position - body[24].transform.position), people[0].up);
        /*Vector3 p0right = body[23].transform.position - body[24].transform.position;
        Vector3 p0forward = Vector3.Cross(people[1].position - body[23].transform.position, people[1].position - body[24].transform.position);
        people[0].rotation = Quaternion.FromToRotation(people[0].up, Vector3.Cross(p0forward, p0right));
        people[0].Rotate(180, 0, 0);*/
          //¸y
        people[1].rotation = Quaternion.Euler(0, 0, 0);
        people[1].rotation = Quaternion.FromToRotation(people[1].up, (body[11].transform.position + body[12].transform.position) / 2 - people[1].position);
        /*float p1u = Quaternion.FromToRotation(people[1].forward, Vector3.Cross(body[12].transform.position - people[1].position, body[11].transform.position - people[1].position)).eulerAngles.y;
        people[1].Rotate(0, p1u, 0);*/
        people[1].rotation = Quaternion.LookRotation(Vector3.Cross(body[12].transform.position - people[1].position, body[11].transform.position - people[1].position), people[1].up);
        /*Vector3 p1up = (body[11].transform.position + body[12].transform.position) / 2 - people[1].position;
        Vector3 p1forward = Vector3.Cross(body[12].transform.position - people[1].position, body[11].transform.position - people[1].position);
        people[1].rotation = Quaternion.FromToRotation(people[1].right, Vector3.Cross(p1forward, p1up));
        people[1].Rotate(0, 180, 0);*/
          //ÀY
        people[5].rotation = Quaternion.Euler(0, 0, 0);
        /*people[5].rotation = Quaternion.FromToRotation(people[5].up, (body[2].transform.position + body[5].transform.position) / 2 - (body[9].transform.position + body[10].transform.position) / 2);
        float p5u = Quaternion.FromToRotation(people[5].forward, Vector3.Cross(body[2].transform.position - body[9].transform.position, body[5].transform.position - body[10].transform.position)).eulerAngles.y;
        people[5].Rotate(0, p5u, 0);*/
        //people[5].rotation = Quaternion.LookRotation(Vector3.Cross(body[5].transform.position - body[10].transform.position, body[2].transform.position - body[9].transform.position), people[5].up);
        Vector3 p5up = (body[2].transform.position + body[5].transform.position) / 2 - (body[9].transform.position + body[10].transform.position) / 2;
        Vector3 p5forward = Vector3.Cross(body[0].transform.position - body[9].transform.position, body[0].transform.position - body[10].transform.position);
        people[5].rotation = Quaternion.FromToRotation(people[5].right, Vector3.Cross(p5forward, p5up));
        people[5].Rotate(0, 180, 0);

        
        //¥ª¸}:7~10
          //»L®Ú
        //people[7].position = body[23].transform.position;
        people[7].rotation = Quaternion.Euler(0, 0, 0);
        people[7].rotation = Quaternion.FromToRotation(people[7].up, body[25].transform.position - body[23].transform.position);
        /*float p7u = Quaternion.FromToRotation(people[7].forward, Vector3.Cross(body[25].transform.position - body[23].transform.position, body[23].transform.position - body[24].transform.position)).eulerAngles.y;
        people[7].Rotate(0, p7u, 0);*/
          //½¥»\
        people[8].rotation = Quaternion.Euler(0, 0, 0);
        people[8].rotation = Quaternion.FromToRotation(people[8].up, body[27].transform.position - body[25].transform.position);
        /*float p8u = Quaternion.FromToRotation(people[8].forward, Vector3.Cross(body[27].transform.position - body[25].transform.position, body[23].transform.position - body[24].transform.position)).eulerAngles.y;
        people[8].Rotate(0, p8u, 0);*/
          //¸}½ï
        people[9].rotation = Quaternion.Euler(0, 0, 0);
        people[9].rotation = Quaternion.FromToRotation(people[9].up, body[31].transform.position - body[27].transform.position);
        /*float p9u = Quaternion.FromToRotation(people[9].forward, Vector3.Cross(body[31].transform.position - body[27].transform.position, body[23].transform.position - body[24].transform.position)).eulerAngles.y;
        people[9].Rotate(0, p9u, 0);*/

        //¥k¸}:11~14
          //»L®Ú
        people[11].rotation = Quaternion.Euler(0, 0, 0);
        people[11].rotation = Quaternion.FromToRotation(people[11].up, body[26].transform.position - body[24].transform.position);
        float p11u = Quaternion.FromToRotation(people[11].forward, Vector3.Cross(body[24].transform.position - body[23].transform.position, body[26].transform.position - body[24].transform.position)).eulerAngles.y;
        people[11].Rotate(0, p11u, 0);
          //½¥»\
        people[12].rotation = Quaternion.Euler(0, 0, 0);
        people[12].rotation = Quaternion.FromToRotation(people[12].up, body[28].transform.position - body[26].transform.position);
          //¸}½ï
        people[13].rotation = Quaternion.Euler(0, 0, 0);
        people[13].rotation = Quaternion.FromToRotation(people[13].up, body[32].transform.position - body[28].transform.position);

        //¥ª¤â:15~17
          //ªÓ»H
        people[15].rotation = Quaternion.Euler(0, 0, 0);
        people[15].rotation = Quaternion.FromToRotation(people[15].up, body[13].transform.position - body[11].transform.position);
          //¤â¨y
        people[16].rotation = Quaternion.Euler(0, 0, 0);
        people[16].rotation = Quaternion.FromToRotation(people[16].up, body[15].transform.position - body[13].transform.position);

        //¥k¤â:18~20
          //ªÓ»H
        //people[18].position = body[12].transform.position;
        people[18].rotation = Quaternion.Euler(0, 0, 0);
        people[18].rotation = Quaternion.FromToRotation(people[18].up, body[14].transform.position - body[12].transform.position);
          //¤â¨y
        people[19].rotation = Quaternion.Euler(0, 0, 0);
        people[19].rotation = Quaternion.FromToRotation(people[19].up, body[16].transform.position - body[14].transform.position);
    }
}
