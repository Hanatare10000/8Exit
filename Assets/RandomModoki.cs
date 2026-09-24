/*using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("看板の見た目設定")]
    [SerializeField] private SpriteRenderer stationSignRenderer;
    [SerializeField] private Sprite[] signSprites;

    [Header("異変の設定")]
    [SerializeField] private GameObject[] anomalyObjects;

    [Header("出口・クリア用設定")]
    [SerializeField] private GameObject exitSignObject;
    [SerializeField] private GameObject stairsObject;
    [SerializeField] private string clearSceneName = "ClearScene";

    [Header("出口限定の演出設定")]
    [SerializeField] private GameObject exitOnlyPoster;

    [Header("0限定の演出設定")]
    [SerializeField] private GameObject zeroOnlyObject;

    [Header("即死イベント演出設定")]
    [SerializeField] private GameObject blackOutPanel;

    private static int currentStage = 0;
    private static bool isGameRestarting = false;

    private bool hasAnomaly = false;
    private int currentActiveAnomalyIndex = -1;
    private bool isDead = false;

    private static int lastActiveAnomalyIndex = -1;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        if (isGameRestarting)
        {
            currentStage = 0;
            isGameRestarting = false;
            lastActiveAnomalyIndex = -1;
        }

        isDead = false;

        if (exitSignObject != null) exitSignObject.SetActive(false);
        if (stairsObject != null) stairsObject.SetActive(false);
        if (exitOnlyPoster != null) exitOnlyPoster.SetActive(false);
        if (blackOutPanel != null) blackOutPanel.SetActive(false);

        ResetBailoutDoors();

        SetAllAnomaliesActive(false);
        UpdateStationSign();
        GenerateNewLoop();
    }

    public void GenerateNewLoop()
    {
        if (currentStage >= 9 || isDead) return;

        SetAllAnomaliesActive(false);
        currentActiveAnomalyIndex = -1;
        if (exitOnlyPoster != null) exitOnlyPoster.SetActive(false);

        if (zeroOnlyObject != null)
        {
            zeroOnlyObject.SetActive(currentStage == 0);
        }

        ResetBailoutDoors();

        if (currentStage == 0)
        {
            hasAnomaly = false;
        }
        else if (currentStage == 8)
        {
            hasAnomaly = Random.Range(0, 100) < 30; //8の時の確率
        }
        else
        {
            hasAnomaly = Random.Range(0, 100) < 65; //1～7の時の確率
        }

        if (hasAnomaly && anomalyObjects != null && anomalyObjects.Length > 0)
        {
            if (anomalyObjects.Length > 1)
            {
                do
                {
                    currentActiveAnomalyIndex = Random.Range(0, anomalyObjects.Length);
                } while (currentActiveAnomalyIndex == lastActiveAnomalyIndex);
            }
            else
            {
                currentActiveAnomalyIndex = 0;
            }

            lastActiveAnomalyIndex = currentActiveAnomalyIndex;

            if (currentActiveAnomalyIndex >= 0 && currentActiveAnomalyIndex < anomalyObjects.Length)
            {
                if (anomalyObjects[currentActiveAnomalyIndex] != null)
                {
                    anomalyObjects[currentActiveAnomalyIndex].SetActive(true);
                }
            }
        }
    }

    public void PlayerSelect(bool isForward)
    {
        if (currentStage >= 9 || isDead) return;

        bool isCorrect = (hasAnomaly && !isForward) || (!hasAnomaly && isForward);

        if (isCorrect)
        {
            if (currentStage == 8)
            {
                if (!hasAnomaly) currentStage++;
            }
            else
            {
                currentStage++;
            }
        }
        else
        {
            currentStage = 0;
        }

        UpdateStationSign();

        if (currentStage >= 9) OnReachExit();
        else GenerateNewLoop();
    }

    public void CaughtByHand()
    {
        if (isDead) return;
        StartCoroutine(CaughtRoutine());
    }

    private IEnumerator CaughtRoutine()
    {
        isDead = true;

        if (blackOutPanel != null) blackOutPanel.SetActive(true);
        yield return new WaitForSeconds(3f);

        currentStage = 0;
        isGameRestarting = false;
        lastActiveAnomalyIndex = -1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UseBailoutButton()
    {
        //hasAnomaly = false; ←もともと扉の異変の時に扉を閉めると異変じゃないって判断するコードがあったけど扉自体が異変のためコメントアウトする
    }

    void OnReachExit()
    {
        SetAllAnomaliesActive(false);
        if (exitOnlyPoster != null) exitOnlyPoster.SetActive(true);
        if (exitSignObject != null) exitSignObject.SetActive(true);
        if (stairsObject != null) stairsObject.SetActive(true);

        if (zeroOnlyObject != null) zeroOnlyObject.SetActive(false);
    }

    void SetAllAnomaliesActive(bool isActive)
    {
        if (anomalyObjects == null) return;
        foreach (var anomaly in anomalyObjects)
        {
            if (anomaly != null) anomaly.SetActive(isActive);
        }
    }

    void UpdateStationSign()
    {
        if (stationSignRenderer == null || signSprites == null || signSprites.Length == 0) return;
        int spriteIndex = Mathf.Clamp(currentStage, 0, signSprites.Length - 1);
        stationSignRenderer.sprite = signSprites[spriteIndex];
    }

    public void ConnectToClearScene()
    {
        isGameRestarting = true;
        SceneManager.LoadScene(clearSceneName);
    }

    private void ResetBailoutDoors()
    {
        BailoutSwitch bailoutScript = Object.FindAnyObjectByType<BailoutSwitch>();
        if (bailoutScript != null)
        {
            Transform switchTransform = bailoutScript.transform;

            Transform openDoor = switchTransform.Find("DoorOpenObject") ?? switchTransform.Find("doorOpenObject");
            Transform closedDoor = switchTransform.Find("DoorClosedObject") ?? switchTransform.Find("doorClosedObject");
            Transform textObj = switchTransform.Find("BailoutTextObject") ?? switchTransform.Find("bailoutTextObject");

            if (openDoor == null && switchTransform.childCount > 0) openDoor = switchTransform.GetChild(0);
            if (closedDoor == null && switchTransform.childCount > 1) closedDoor = switchTransform.GetChild(1);

            if (openDoor != null) openDoor.gameObject.SetActive(true);
            if (closedDoor != null) closedDoor.gameObject.SetActive(false);
            if (textObj != null) textObj.gameObject.SetActive(false);
        }
    }
}*/