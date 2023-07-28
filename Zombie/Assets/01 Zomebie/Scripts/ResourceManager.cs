using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance; // 싱글톤이 할당될 static 변수
    public static ResourceManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }

    private static string zombieDataPath = default;

    public ZombieData zombieData_default = default;

    public List<ZombieData2> zombieDatas = default;

    private void Awake()
    {
        //ZombieDatas 초기화
        zombieDatas = new List<ZombieData2>();

        zombieDataPath = "ZombieDatas";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "ZombieSurvival Datas - ZombieDatas"); //이 왼쪽에 좀비데이터 엑셀파일 이름 적으세요

        TextAsset csvZombieData = Resources.Load<TextAsset>(zombieDataPath);

        string[] zombieDatas_str = csvZombieData.text.Split('\n');
        ZombieData2 loadZombieData = default;
        for (int i = 1; i < zombieDatas_str.Length; i++)
        {
            loadZombieData = new ZombieData2(zombieDatas_str[i]);
            zombieDatas.Add(loadZombieData);

        }
    }





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}